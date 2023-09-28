using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class CharacterInteraction : MonoBehaviour
{
    public GameObject vcInteraction;
    public GameObject vcPrevious;
    public GameObject glassEye;
    public GameObject drugItem;
    




    public Rigidbody _rb;
    
    public bool isDialogueOpen;
    public bool hasDrugs;

    public BlockReference noGlassEyeInteraction;
    public BlockReference glassEyeInteraction;

    // Reference to the PlayerController script
    public PlayerController playerController;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            vcPrevious.SetActive(false);
            vcInteraction.SetActive(true);
            isDialogueOpen = true;
            Invoke("Dialogue", 2f);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            vcPrevious.SetActive(true);
            vcInteraction.SetActive(false);
            glassEyeInteraction.block.Stop();
            noGlassEyeInteraction.block.Stop();

        }
    }

    public void Dialogue()
    {
        if (isDialogueOpen)
        {
            //_rb.constraints = RigidbodyConstraints.FreezePosition;

            if (playerController.HasGlassEye == true)
            {
                glassEyeInteraction.Execute();
                glassEye.SetActive(false);
                Invoke("GetDrugs", 1f);
            }
            else
            {
                noGlassEyeInteraction.Execute();
                
            }

           
            // Use a coroutine to wait for the dialogue to finish
            
        }
    }

   public void SwitchCamera()
    {
        isDialogueOpen = false;
        //_rb.constraints = RigidbodyConstraints.None;
        //_rb.constraints = RigidbodyConstraints.FreezeRotation;

        this.gameObject.GetComponent<SphereCollider>().enabled = false;
        Invoke("DialogueReactivate", 5f);
        vcInteraction.SetActive(false);
        vcPrevious.SetActive(true);
    }

    public void GetDrugs()
    {
        drugItem.SetActive(true);
        playerController.HasDrugs = true;
        hasDrugs = true;
    }

    //public void CancelText()
    //{
    //    isDialogueOpen = false;
    //    _rb.constraints = RigidbodyConstraints.None;
    //    _rb.constraints = RigidbodyConstraints.FreezeRotation;
    //    Invoke("DialogueReactivate", 5f);
    //    vcInteraction.SetActive(false);
    //    vcPrevious.SetActive(true);
    //}

    public void DialogueReactivate()
    {
        this.gameObject.GetComponent<SphereCollider>().enabled = true;
    }
}

