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
    public Gears Gears;

    bool canLoseLife;

    public AudioClip loseLifeSFX;

    void Start()
    {
        canLoseLife = true;
        check = player.GetComponent<Checkpoint>();
        rigid = player.GetComponent<Rigidbody>();
        Debug.Log("Player has " + lives + " lives");
    }

    void Update()
    { 
        if (lives < 3 && life1.activeSelf == true)
        {
            LeanTween.alpha(life1.GetComponent<RectTransform>(), 0f, 0.5f).setOnComplete(RemoveStarOne);
        }

        if (lives < 2 && life2.activeSelf == true)
        {
            LeanTween.alpha(life2.GetComponent<RectTransform>(), 0f, 0.5f).setOnComplete(RemoveStarTwo);
        }

        if (lives < 1 && life3.activeSelf == true)
        {
            LeanTween.alpha(life3.GetComponent<RectTransform>(), 0f, 0.5f).setOnComplete(RemoveStarThree);
            GameOverUI.SetActive(true);
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
        Gears.Gear= 0;
    }

    void RemoveStarOne() => life1.SetActive(false);
    void RemoveStarTwo() => life2.SetActive(false);
    void RemoveStarThree() => life3.SetActive(false);
}
