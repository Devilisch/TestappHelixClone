using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ScoreScript : MonoBehaviour
{
    public GameObject ball;
    public GameObject respawn;
    private int score = 0;
    private float startPosition = 0f;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = respawn.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if ( score < startPosition - ball.transform.position.y )
        {
            score = (int) Math.Round(startPosition - ball.transform.position.y) ;
        }
        if ( ball.transform.position.y == startPosition )
        {
            score = 0;
        }
        GetComponent<Text>().text = score.ToString();
    }
}
