using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinMenuControl : MonoBehaviour
{
    public void ShowStartMenu() {
        Application.LoadLevel("MainMenuScene");
    }

    public void ExitFromTheGame() {
        Application.Quit();
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
