using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuControl : MonoBehaviour
{
    public GameObject StartMenu;
    public GameObject InfoMenu;
    public GameObject ExitMenu;

    public void ShowInfoMenu() {
        StartMenu.SetActive(false);
        InfoMenu.SetActive(true);
    }

    public void ShowExitMenu() {
        StartMenu.SetActive(false);
        ExitMenu.SetActive(true);
    }

    public void ShowStartMenu() {
        InfoMenu.SetActive(false);
        ExitMenu.SetActive(false);
        StartMenu.SetActive(true);
    }

    public void ExitFromTheGame() {
        Application.Quit();
    }

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }
}
