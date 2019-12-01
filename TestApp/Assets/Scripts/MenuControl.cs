using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuControl : MonoBehaviour
{
    public GameObject StartMenu;
    public GameObject InfoMenu;
    public GameObject ExitMenu;

    public AudioClip tap;
    public AudioClip theme;

    public void ShowInfoMenu() {
        GetComponent<AudioSource>().PlayOneShot(tap);
        StartMenu.SetActive(false);
        InfoMenu.SetActive(true);
    }

    public void ShowExitMenu() {
        GetComponent<AudioSource>().PlayOneShot(tap);
        StartMenu.SetActive(false);
        ExitMenu.SetActive(true);
    }

    public void ShowStartMenu() {
        GetComponent<AudioSource>().PlayOneShot(tap);
        InfoMenu.SetActive(false);
        ExitMenu.SetActive(false);
        StartMenu.SetActive(true);
    }

    public void ExitFromTheGame() {
        GetComponent<AudioSource>().PlayOneShot(tap);
        Application.Quit();
    }

    public void StartNewGame() {
        Application.LoadLevel("LevelsScene");
    }

    // Start is called before the first frame update
    void Start() {
        GetComponent<AudioSource>().PlayOneShot(theme, 0.3f);
    }

    // Update is called once per frame
    void Update() {
        
    }
}
