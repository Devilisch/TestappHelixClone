using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject ball;
    public GameObject respawn;
    private float cameraPositionY;

    void Start() {
        cameraPositionY = ball.transform.position.y;
    }

    void Update() {
        if ( ( cameraPositionY > ball.transform.position.y ) | ( respawn.transform.position.y == ball.transform.position.y ) )
            cameraPositionY = ball.transform.position.y;

        transform.position = new Vector3 (ball.transform.position.x, cameraPositionY + 3, ball.transform.position.z - 3);
    }
}
