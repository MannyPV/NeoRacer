using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Gears : MonoBehaviour
{
    public int Gear;
    public int MaxGear= 6;
    public float MaxVelocity;
    private bool axisInuse = false;
    public Text GearCount; // The Gear text on the UI
    public CarDrive carDrive;
    // Start is called before the first frame update
    void Start()
    {
        Gear = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GearSpeed();
        GearShift();
    }
     void GearShift()
    {
        if(Input.GetButtonDown("GearUp") || Input.GetAxisRaw("VerticalTurn") == 1)
        {
            if(axisInuse == false)
            {
                axisInuse = true;
                if (Gear != MaxGear)
                {
                    if(carDrive.CurrentSpeed >= MaxVelocity)
                    {
                        Gear++;
                    }
                }
            }
        }
        if(Input.GetButtonDown("GearDown") || Input.GetAxisRaw("VerticalTurn") == -1)
        {
            if(axisInuse == false)
            {
                axisInuse = true;
                if (Gear != 0)
                {
                    Gear--;
                }
            }
        }
        if(Input.GetAxisRaw("VerticalTurn") == 0)
        {
            axisInuse =false;
        }
    } 
    void GearSpeed()
    {
        switch(Gear)
        {
            case 0:
                MaxVelocity=30;
                break;
            case 1:
                MaxVelocity=63;
                break;
            case 2:
                MaxVelocity=90;
                break;
            case 3:
                MaxVelocity=120;
                break;
            case 4:
                MaxVelocity=150;
                break;
            case 5:
                MaxVelocity=200;
                break;
            case 6:
                MaxVelocity=500;
                break;
            default:
                MaxVelocity=30;
                break;
        }
        GearCount.text = "Gear: " + Gear;
    }
}
