using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCheck : MonoBehaviour
{
    public bool NewCheckPoint;
    public Checkpoint Checkpoint;
    public int ArrowTurnSpeed = 2;
    public GameObject[] CheckpointArrow;
    public int nextArrowPoint = 1;

    void Start()
    {
        NewCheckPoint = false;
    }
    void Update()
    {  
        LookAtCheckPoint();
    }
    void LookAtCheckPoint()
    {   /*
        Quaternion _lookRotation = Quaternion.LookRotation((Checkpoint.respawnSpot.transform.position - transform.position).normalized);
        transform.rotation = Quaternion.Slerp(transform.rotation, _lookRotation, Time.deltaTime * ArrowTurnSpeed);
        NewCheckPoint = false;
        */
        /*
        Vector3 difference = Checkpoint.respawnSpot.transform.position - transform.position;
        float rotationY = Mathf.Atan2(difference.x, difference.z) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0.0f, rotationY, 0.0f);
        NewCheckPoint = false;
        */
        if(nextArrowPoint == CheckpointArrow.Length )
        {
            nextArrowPoint = 0;
        }
        GameObject Arrowpoint = CheckpointArrow[nextArrowPoint];
        Vector3 lookRot = Arrowpoint.transform.position - transform.position;
        Quaternion rotation=   Quaternion.LookRotation(lookRot);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, Time.deltaTime * ArrowTurnSpeed);
        
        if(NewCheckPoint == true)
        {
            nextArrowPoint++;
            NewCheckPoint =false;
        }
        
    }
}
