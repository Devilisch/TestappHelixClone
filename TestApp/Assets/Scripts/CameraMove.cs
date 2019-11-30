using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject FocusOn;

    void Start() {
        
    }

    void Update() {
        transform.position = new Vector3 (FocusOn.transform.position.x, FocusOn.transform.position.y + 3, FocusOn.transform.position.z - 3);
    }
}
