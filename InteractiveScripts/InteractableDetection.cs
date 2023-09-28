using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableDetection : MonoBehaviour
{
    public BoxCollider boxCollider;
    public GameObject spriteObject;
    


    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("DetectiveMode"))
        {
            spriteObject.SetActive(true);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("DetectiveMode"))
        {
            spriteObject.SetActive(false);
        }
    }

}
