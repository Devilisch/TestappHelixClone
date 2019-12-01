using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ScoreScript : MonoBehaviour
{
    public GameObject ball;
    public GameObject respawn;
    public bool scoreInNextLevelMenu = false;
    public bool scoreInWinMenu = false;
    private int score = 0;
    private float startPosition = 0f;

    void Start() {
        startPosition = respawn.transform.position.y;
    }

    void Update() {
        if ( score < startPosition - ball.transform.position.y ) {
            score = (int) Math.Round(startPosition - ball.transform.position.y) ;
        }

        if ( ball.transform.position.y == startPosition ) {
            score = 0;
        }

        if (scoreInNextLevelMenu) GetComponent<Text>().text = "You score: " + score.ToString() + "\nLet's go to the next level?";
        else if (scoreInWinMenu) GetComponent<Text>().text = "You score: " + score.ToString() + "\nYou won!";
        else GetComponent<Text>().text = "Score: " + score.ToString();
    }
}
