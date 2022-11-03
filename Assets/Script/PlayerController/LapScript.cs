using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LapScript : MonoBehaviour
{
    public AudioClip lapSFX;

    public int TotalLaps= 3;
    public int CurrentLaps=1;

    public GameObject WinStateUI;

    bool CanDoLaps;
    float timeBetweenLaps;
    public float minTimeBetweenLaps = 30f;

    public Text LapDisplayText;

    public bool isPlayer;

    public Checkpoint Checkpoint; 
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
            SoundManager.instance.PlaySFX(lapSFX);

            CurrentLaps += 1;
            CanDoLaps = false;
            Checkpoint.currentCheckPoint=0;
        }

        if(other.tag == "Lap" && CurrentLaps > TotalLaps)
        {
            WinStateUI.SetActive(true);
        }
    }
}
