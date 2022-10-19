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

    public Text speedometer; // The speed text on the UI

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
        Fall();
    }

    void Move()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetAxisRaw("Vertical") == 1)
        {
            Vector3 forceToAdd = transform.forward;
            forceToAdd.y = 0;
            rb.AddForce(forceToAdd * Speed * multiplier);
        }
        else if(Input.GetKey(KeyCode.S)|| Input.GetAxisRaw("Vertical")== -1)
        {
            Vector3 forceToAdd = -transform.forward;
            forceToAdd.y = 0;
            rb.AddForce(forceToAdd * Speed * multiplier);
        }

        Vector3 localVelocity = transform.InverseTransformDirection(rb.velocity);
        localVelocity = new Vector3(0,localVelocity.y,localVelocity.z);
        rb.velocity = new Vector3(transform.TransformDirection(localVelocity).x,rb.velocity.y , transform.TransformDirection(localVelocity).z);

        RecordSpeed(); // New function below to update ui text
    }

    void Fall()
    {
        rb.AddForce(Vector3.down * gravityMultiplier * multiplier);
    }

    void RecordSpeed()
    {
        speedometer.text = "Speed: " + (int)rb.velocity.magnitude*3;
        // Changes the text on the UI to whatever the speed is as an int. *3 because the numbers make more sense that way.
    }
}
