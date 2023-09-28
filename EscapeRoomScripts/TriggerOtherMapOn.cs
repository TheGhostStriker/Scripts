using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerOtherMapOn : MonoBehaviour
{
    public GameObject mainMansion;

    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            mainMansion.SetActive(true);
        }
    }
}
