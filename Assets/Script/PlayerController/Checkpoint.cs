using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public GameObject respawnSpot;
    public int TotalCheckpoints;
    public int currentCheckPoint=0;
    public LookAtCheck LookAtCheck;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Respawn"))
        {
            currentCheckPoint= currentCheckPoint + 1; 
            LookAtCheck.NewCheckPoint = true;
            Debug.Log("New Respawn Spot");
            respawnSpot = other.gameObject;
        }
    }
}
