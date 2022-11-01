using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarLives : MonoBehaviour
{
    public int lives = 3;

    public GameObject life1;
    public GameObject life2;
    public GameObject life3;

    public GameObject GameOverUI;

    public GameObject player;
    Rigidbody rigid;
    Checkpoint check;

    bool canLoseLife;

    public AudioClip loseLifeSFX;

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
            LeanTween.alpha(life1.GetComponent<RectTransform>(), 0f, 0.5f).setOnComplete(RemoveStarOne);
            //life1.SetActive(false);
        }

        if (lives < 2 && life2.activeSelf == true)
        {
            //Debug.Log("Life 2 disabled");
            LeanTween.alpha(life2.GetComponent<RectTransform>(), 0f, 0.5f).setOnComplete(RemoveStarTwo);
            //life2.SetActive(false);
        }

        if (lives < 1 && life3.activeSelf == true)
        {
            //Debug.Log("Life 3 disabled");
            LeanTween.alpha(life3.GetComponent<RectTransform>(), 0f, 0.5f).setOnComplete(RemoveStarThree);
            //life3.SetActive(false);

            Debug.Log("PLAYER LOSE");
            GameOverUI.SetActive(true);
            //LoadLoseScreen();

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (canLoseLife) // this is to prevent losing two lives with one hit
        {
            canLoseLife = false;
            lives--;
            
            SoundManager.instance.PlaySFX(loseLifeSFX);

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

    void RemoveStarOne()
    {
        life1.SetActive(false);
    }

    void RemoveStarTwo()
    {
        life2.SetActive(false);
    }

    void RemoveStarThree()
    {
        life3.SetActive(false);
    }


}
