﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject FocusOn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3 (FocusOn.transform.position.x, FocusOn.transform.position.y + 3, FocusOn.transform.position.z - 3);
    }
}