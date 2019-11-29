using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MainController : MonoBehaviour
{
    public float speed = 1000f;
    private bool buttonDown = false;
    private float moveOn = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetAxis("Horizontal") != 0)
        {
            buttonDown = true;
        }
        else
        {
            buttonDown = false;
        }

        if (buttonDown)
        {
            moveOn = Input.GetAxis("Horizontal");
        }
    }


    void FixedUpdate()
    {
        if (buttonDown)
        {
            moveOn = Input.GetAxis("Horizontal");
            Quaternion rotationNow = transform.rotation;
            rotationNow.y +=  Math.Sign(moveOn) * speed * Time.deltaTime;
            transform.rotation = rotationNow;
        }
    }
}
