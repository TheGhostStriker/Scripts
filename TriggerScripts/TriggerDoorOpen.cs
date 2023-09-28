using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoorOpen : MonoBehaviour
{

    public Animator doorAnim;
    public AudioSource doorOpenAudio;
    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            doorAnim.SetBool("trigger", true);
            doorOpenAudio.Play();
        }
    }
}
