using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    private float visiblePosZ = -6.5f;
    private GameObject gameoverText;
    private int score = 0;
    private GameObject scoreText;

    // Use this for initialization
    void Start()
    {
        this.gameoverText = GameObject.Find("GameOverText");
        this.scoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.z < this.visiblePosZ)
        {
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        switch(collision.gameObject.tag)
        {
            case "StarTag":
                this.score += 2;
                break;
            case "CloudTag":
                this.score += 15;
                break;
            case "SmallCloudTag":
                this.score += 5;
                break;
        }
        this.scoreText.GetComponent<Text>().text = ("score: " + this.score);
    }
}