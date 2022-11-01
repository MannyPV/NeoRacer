using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    float timer;
    public Text countdown;
    public Image countBack;

    public GameObject player;
    CarDrive driveScript;
    CarTurn turnScript;

    bool clearCounter;
    float clearTimer;

    public AudioClip bgMusic;
    public AudioClip countSFX;

    void Start()
    {
        SoundManager.instance.PlaySFX(countSFX);
        SoundManager.instance.PlayMusic(bgMusic);

        timer = 8;

        countdown.text = "...";
        //countdown.color = Color.white;

        driveScript = player.GetComponent<CarDrive>();
        turnScript = player.GetComponent<CarTurn>();

        clearCounter = false;
        clearTimer = 0;
    }

    private void Update()
    {
        if((int)timer >= 4)
        {
            timer -= Time.deltaTime;
        }
        else if ((int)timer > 0 && (int)timer < 4)
        {
            timer -= Time.deltaTime;

            if ((int)timer != 0)
            {
                countdown.color = Color.red;
                countdown.text = "" + ((int)timer);
            }
        }
        else
        {
            countdown.text = "GO!";
            countdown.color = Color.green;
            GivePlayerControl();
            timer = 0;

            clearCounter = true;
        }

        if(clearCounter == true)
        {
            ClearCounterUI();
        }
    }

    void GivePlayerControl()
    {
        driveScript.enabled = true;
        turnScript.enabled = true;
    }

    void ClearCounterUI()
    {
        clearTimer += Time.deltaTime;
        if(clearTimer > 2)
        {
            countdown.enabled = false;
            countBack.enabled = false;
            enabled = false;
        }
    }

    

}
