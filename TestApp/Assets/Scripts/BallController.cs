using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

    public GameObject respawn;
    public GameObject nextLevelMenu;
    public GameObject winMenu;
    public AudioClip tap;
    public AudioClip crash;
    public AudioClip win;
    public AudioClip theme;
    private Rigidbody ball;
    public GameObject ballGO;
    
    private bool collision = false;
    public float jumpForce = 250f;
    public float destroyTime = 0.1f;
    public float lvlDownForce = 5f;

    void Start() {
        ball = GetComponent <Rigidbody> ();
        GetComponent<AudioSource>().PlayOneShot(theme, 0.1f);
    }

    void OnCollisionEnter( Collision obj ) {
        if (collision) 
            return;
        
        switch (obj.gameObject.tag) {
            case "Block":
                GetComponent<AudioSource>().PlayOneShot(tap);
                ball.AddForce( Vector3.up * jumpForce );
                break;
            case "Red block":
                Application.LoadLevel("DeathMenuScene");
                break;
            case "Blue block":
                GetComponent<AudioSource>().PlayOneShot(crash);
                ball.AddForce( Vector3.up * jumpForce );
                Destroy(obj.gameObject, destroyTime);
                break;
            case "Black block":
                break;
            case "Finish block":
                GetComponent<AudioSource>().PlayOneShot(win);
                nextLevelMenu.SetActive(true);
                ball.MovePosition( ball.position + Vector3.down * lvlDownForce); 
                break;
            case "Win block":
                GetComponent<AudioSource>().PlayOneShot(win);
                winMenu.SetActive(true);
                break;
        }

        collision = true;
    }

    void OnCollisionExit( Collision obj ) {
        collision = false;
    }
}
