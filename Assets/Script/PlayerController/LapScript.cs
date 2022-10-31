using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LapScript : MonoBehaviour
{   
    public int TotalLaps= 3;
    public int CurrentLaps=1;

    public GameObject WinStateUI;

    bool CanDoLaps;
    float timeBetweenLaps;
    public float minTimeBetweenLaps = 30f;

    public Text LapDisplayText;

    public bool isPlayer;
    void Update()
    {
        if(timeBetweenLaps <= 0)
        {
            CanDoLaps = true;
            timeBetweenLaps= minTimeBetweenLaps;
        }
        else
        {
            timeBetweenLaps-= Time.deltaTime;
        }

        if(isPlayer)
        {
            LapDisplayText.text = "Laps: " + CurrentLaps+ "/" + TotalLaps;
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Lap" && CanDoLaps)
        {
            CurrentLaps +=1;
            CanDoLaps = false;
        }

        if(other.tag == "Lap" && CurrentLaps > TotalLaps)
        {
            WinStateUI.SetActive(true);
        }
    }
}
