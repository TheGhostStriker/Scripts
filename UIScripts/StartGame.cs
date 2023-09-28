using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject finalCam;
    public GameObject playerCharacter;
    public GameObject healthBar;
    public GameObject comicBook;
    public GameObject finalButton;
    public GameObject startingCam;
    public PauseMenu pauseMenu;
    

    public void OnButtonPressed()
    {
        finalCam.SetActive(false);
        playerCharacter.SetActive(true);
        healthBar.SetActive(true);
        comicBook.SetActive(false);
        finalButton.SetActive(false);
        startingCam.SetActive(true);
        pauseMenu.isComicActive = false;
    }
}
