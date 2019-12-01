using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

    public GameObject respawn;
    public GameObject nextLevelMenu;
    public GameObject winMenu;
    private Rigidbody ball;
    private bool collision = false;
    public float jumpForce = 250f;
    public float destroyTime = 0.1f;
    public float lvlDownForce = 5f;

    void Start() {
        ball = GetComponent <Rigidbody> ();
    }

    void OnCollisionEnter( Collision obj ) {
        if (collision) 
            return;
        
        switch (obj.gameObject.tag) {
            case "Block":
                ball.AddForce( Vector3.up * jumpForce );
                break;
            case "Red block":
                //ball.transform.position = respawn.transform.position;
                Application.LoadLevel("DeathMenuScene");
                break;
            case "Blue block":
                ball.AddForce( Vector3.up * jumpForce );
                Destroy(obj.gameObject, destroyTime);
                break;
            case "Black block":
                break;
            case "Finish block":
                nextLevelMenu.SetActive(true);
                ball.MovePosition( ball.position + Vector3.down * lvlDownForce); 
                break;
            case "Win block":
                winMenu.SetActive(true);
                break;
        }

        collision = true;
    }

    void OnCollisionExit( Collision obj ) {
        collision = false;
    }
}
