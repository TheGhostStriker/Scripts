using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffAudio : MonoBehaviour
{
    public GameObject upsideDownAudio;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            upsideDownAudio.SetActive(false);
        }

    }
}
