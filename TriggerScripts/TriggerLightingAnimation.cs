using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLightingAnimation : MonoBehaviour
{
    
    public Animator lightAnim;
   
    

    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            lightAnim.SetBool("flickerOn", true);
            
            
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            lightAnim.SetBool("flickerOn", false);
            
        }
    }
}
