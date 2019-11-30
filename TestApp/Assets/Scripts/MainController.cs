using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MainController : MonoBehaviour {
    public float speed = 1f;
    private float moveOn = 0f;

    void Start() {
        
    }

    void Update() {
        moveOn = Input.GetAxis("Horizontal");
        Quaternion rotationNow = transform.rotation;
        if ( moveOn != 0) {
            rotationNow.y +=  Math.Sign(moveOn) * speed * Time.deltaTime;
            Console.WriteLine("%f\n", rotationNow.y);
            if ( (rotationNow.y < -170) | ( rotationNow.y > 175 ) ) {
                rotationNow.y = -1 * Math.Sign(rotationNow.y);
            }
            transform.rotation = rotationNow;
        }
    }
}
