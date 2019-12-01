using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathMenuControl : MonoBehaviour
{
    public void ShowStartMenu() {
        Application.LoadLevel("MainMenuScene");
    }

    public void StartNewGame() {
        Application.LoadLevel("Level1Scene");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
