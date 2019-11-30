using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MainController : MonoBehaviour {
    public float speed = 1000f;
    private float moveOn = 0f;

    void Start() {
        
    }

    void Update() {
        moveOn = Input.GetAxis("Horizontal");
        if ( moveOn != 0) {
            Quaternion rotationNow = transform.rotation;
            rotationNow.y +=  Math.Sign(moveOn) * speed * Time.deltaTime;
            transform.rotation = rotationNow;
        }
    }
}
