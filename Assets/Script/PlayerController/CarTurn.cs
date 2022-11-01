using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarTurn : MonoBehaviour
{
    
    private Rigidbody rb;
    public float TurnSpeed = 4f;
    public float TurnSpeedOnAngle = 8f;
    public int multiplier = 10;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(!PauseMenu.isPaused)
        {
        Turn();
        OnAngle();
        }
    }

    
     void Turn()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetAxisRaw("Horizontal") == -1)
        {
            rb.AddTorque(-Vector3.up * TurnSpeed * multiplier);
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetAxisRaw("Horizontal") == 1)
        {
            rb.AddTorque(Vector3.up * TurnSpeed * multiplier);
        }
    }
    void OnAngle()
    {
        if(transform.rotation.eulerAngles.x >= 15 || transform.rotation.eulerAngles.x <= -15)
        {
            TurnSpeed = TurnSpeedOnAngle;
        }
        else
        {
            TurnSpeed = 4f;
        }
    }
}
