using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed = 10f;
    public float jumpForce = 250f;
    public GameObject respawn;
    private bool collision = false;
    private Rigidbody ball;

    // Start is called before the first frame update
    void Start()
    {
        ball = GetComponent <Rigidbody> ();
    }

    void OnCollisionEnter( Collision obj ) {
        if (collision) return;
        if (obj.gameObject.tag == "Block" ) {
            ball.AddForce( Vector3.up * jumpForce );
        }

        if (obj.gameObject.tag == "Red block" ) {
            ball.transform.position = respawn.transform.position;
        }
        /*
        if (obj.tag == "Glass block" ) {
            ball.AddForce( Vector2.up * 5000 );
            Destroy(obj.gameObject);
        }*/
        if (obj.gameObject.tag == "Finish block" ) {
            ball.MovePosition( ball.position + Vector3.down * 5f);
        }
        collision = true;
    }

    void OnCollisionExit( Collision obj ) {
        collision = false;
    }

}
