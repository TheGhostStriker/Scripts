using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerHallowedScream : MonoBehaviour
{
    public AudioSource screamAudio;
    // Start is called before the first frame update

    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if (!screamAudio.isPlaying)
            {
                screamAudio.Play();
            }
            else
            {
                screamAudio.Stop();
            }
        }
    }
}
