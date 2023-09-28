using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VCTriggerSwap : MonoBehaviour
{
    public GameObject previousVC;
    public GameObject newVC;
    public GameObject backwardsTrigger;
    public GameObject thisTrigger;
    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            previousVC.SetActive(false);
            newVC.SetActive(true);
            Invoke("SwitchTriggers", 5f);
           
            Debug.Log("Player has entered collider");
        }
        
    }

    public void SwitchTriggers()
    {
       backwardsTrigger.SetActive(true);
       thisTrigger.SetActive(false);
    }
}
