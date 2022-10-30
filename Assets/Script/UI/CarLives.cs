using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarLives : MonoBehaviour
{
    public int lives = 3;

    public GameObject life1;
    public GameObject life2;
    public GameObject life3;

    public GameObject player;
    Rigidbody rigid;
    Checkpoint check;

    bool canLoseLife;

    // Start is called before the first frame update
    void Start()
    {
        canLoseLife = true;
        check = player.GetComponent<Checkpoint>();
        rigid = player.GetComponent<Rigidbody>();
        Debug.Log("Player has " + lives + " lives");
    }

    // Update is called once per frame
    void Update()
    {   // this script sucks sorry lmao
        if (lives < 3 && life1.activeSelf == true)
        {
            //Debug.Log("Life 1 disabled");
            life1.SetActive(false);
        }

        if (lives < 2 && life2.activeSelf == true)
        {
            //Debug.Log("Life 2 disabled");
            life2.SetActive(false);
        }

        if (lives < 1 && life3.activeSelf == true)
        {
            //Debug.Log("Life 3 disabled");
            life3.SetActive(false);

            Debug.Log("PLAYER LOSE");
            LoadLoseScreen();

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (canLoseLife) // this is to prevent losing two lives with one hit
        {
            canLoseLife = false;
            lives--;
            Debug.Log("Player has " + lives + " lives");
            ResetPlayer();
        }
    }

    void ResetPlayer()
    {
        player.transform.SetPositionAndRotation(check.respawnSpot.transform.position, check.respawnSpot.transform.rotation);
        rigid.velocity = Vector3.zero;
        rigid.angularVelocity = Vector3.zero;
        canLoseLife = true;
    }

    void LoadLoseScreen()
    {

    }
}
