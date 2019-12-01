using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevelMenuControl : MonoBehaviour
{
    public GameObject NextLevelMenu;
    public AudioClip tap;

    public void ShowStartMenu() {
        Application.LoadLevel("MainMenuScene");
    }

    public void StartNextLevel() {
        GetComponent<AudioSource>().PlayOneShot(tap);
        NextLevelMenu.SetActive(false);
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
