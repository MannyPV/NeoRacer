using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPlayer : MonoBehaviour
{
    public GameObject player;

    Checkpoint check;
    Rigidbody rigid;

    private void Start()
    {
        check = player.GetComponent<Checkpoint>();
        rigid = player.GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player died");

            player.transform.SetPositionAndRotation(check.respawnSpot.transform.position, check.respawnSpot.transform.rotation);
            rigid.velocity = Vector3.zero;
            rigid.angularVelocity = Vector3.zero;
        }
    }
}
