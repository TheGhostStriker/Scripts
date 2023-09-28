using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncerInteraction : MonoBehaviour
{
    public GameObject noDrugsCamera;
    public GameObject hasDrugsCamera;

    public GameObject noDrugsComic;
    public GameObject hasDrugsComic;

    public GameObject healthBar;

    public PlayerController playerController;
    public GameObject buttonToGoNext;
    public GameObject buttonToGoNextDrugs;
    public GameObject inventorySystem;

    public GameObject bouncerMan;
    public PauseMenu pauseMenu;
    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if (playerController.HasDrugs == true)
            {
                hasDrugsCamera.SetActive(true);
                hasDrugsComic.SetActive(true);
                healthBar.SetActive(false);
                playerController.enabled = false;
                Invoke("SpawnButtonForDrugs", 3f);
                inventorySystem.SetActive(false);
                bouncerMan.GetComponent<SphereCollider>().enabled = true;
                pauseMenu.isComicActive = true;
                
            }
            else
            {
                noDrugsCamera.SetActive(true);
                noDrugsComic.SetActive(true);
                healthBar.SetActive(false);
                playerController.enabled = false;
                Invoke("SpawnButton", 3f);
                inventorySystem.SetActive(false);
                Invoke("TurnOffCollider", 10f);
                pauseMenu.isComicActive = true;
            }

            
        }
    }

    public void SpawnButton()
    {
        buttonToGoNext.SetActive(true);
    }

    public void SpawnButtonForDrugs()
    {
        buttonToGoNextDrugs.SetActive(true);
    }

    public void TurnOffCollider()
    {
        bouncerMan.GetComponent<SphereCollider>().enabled = false;
    }
}
