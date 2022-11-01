using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarDrive : MonoBehaviour
{
    private Rigidbody rb;

    public float Speed = 8f;
    public int multiplier = 10;
    public float gravityMultiplier = 5f;
    public bool reverse;
    public int CurrentSpeed;
    public Gears Gear;

    public Text speedometer; // The speed text on the UI

    public AudioClip engineSFX;

    // Start is called before the first frame update
    void Start()
    {
        SoundManager.instance.PlayEngineSFX(engineSFX);

        rb = GetComponent<Rigidbody>();
        reverse = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(!PauseMenu.isPaused)
        {
        Move();
        Fall();
        Reverse();
        }
    }

    void Move()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetAxisRaw("RightTrigger") > 0)
        {
            if(reverse == true)
            {
                Vector3 forceToAdd = -transform.forward;
                forceToAdd.y = 0;
                rb.AddForce(forceToAdd * Speed * multiplier);
            }
            else
            {
                if((int)rb.velocity.magnitude*3 <= Gear.MaxVelocity)
                {
                    Vector3 forceToAdd = transform.forward;
                    forceToAdd.y = 0;
                    rb.AddForce(forceToAdd * Speed * multiplier);
                }
            }
        }
        
        Vector3 localVelocity = transform.InverseTransformDirection(rb.velocity);
        localVelocity = new Vector3(0,localVelocity.y,localVelocity.z);
        rb.velocity = new Vector3(transform.TransformDirection(localVelocity).x,rb.velocity.y , transform.TransformDirection(localVelocity).z);

        RecordSpeed(); // New function below to update ui text
    }
    void Reverse()
    {
        if(Input.GetKey(KeyCode.JoystickButton8))
        {
            if(reverse == true)
            {
                reverse = false;
            }
            else
            {
               reverse = true; 
            }
        } 
    }

    void Fall()
    {
        rb.AddForce(Vector3.down * gravityMultiplier * multiplier);
    }

    void RecordSpeed()
    {
        speedometer.text = "Speed: " + (int)rb.velocity.magnitude*3;
        CurrentSpeed=(int)rb.velocity.magnitude*3; 
        // Changes the text on the UI to whatever the speed is as an int. *3 because the numbers make more sense that way.
    }

   
}
