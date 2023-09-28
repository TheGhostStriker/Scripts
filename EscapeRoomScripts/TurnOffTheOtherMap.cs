using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffTheOtherMap : MonoBehaviour
{
    public GameObject mansionOne;
    // Start is called before the first frame update
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            mansionOne.SetActive(false);
        }
    }
}
