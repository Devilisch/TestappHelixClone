using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathMenuControl : MonoBehaviour
{
    public AudioClip death;

    public void ShowStartMenu() {
        Application.LoadLevel("MainMenuScene");
    }

    public void StartNewGame() {
        Application.LoadLevel("LevelsScene");
    }

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().PlayOneShot(death);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
