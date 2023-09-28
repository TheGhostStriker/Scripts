using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnToGamePlay : MonoBehaviour
{
    public PlayerController playerController;
    public GameObject healthBar;
    public GameObject comicBook;
    public GameObject BouncerAlleyWayCam;
    public GameObject comicBookCam;
    public GameObject bouncer;
    public GameObject proceedButton;
    public GameObject inventorySystem;
    public PauseMenu pauseMenu;

    public void OnButtonClicked()
    {
        playerController.enabled = true;
        healthBar.SetActive(true);
        comicBook.SetActive(false);
        BouncerAlleyWayCam.SetActive(true);
        comicBookCam.SetActive(false);
        bouncer.GetComponent<SphereCollider>().enabled = false;
        proceedButton.SetActive(false);
        inventorySystem.SetActive(true);
        Invoke("ResetCollider", 10f);
        pauseMenu.isComicActive = false;
        
    }

    public void ResetCollider()
    {
        bouncer.GetComponent<SphereCollider>().enabled = true;
    }
}
