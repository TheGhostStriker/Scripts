using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TriggerSecretEnding : MonoBehaviour
{
    public UnityStandardAssets.Characters.FirstPerson.FirstPersonController _FPSController = null;
    public GameObject secretEnding;
    public Animator doorAnim;
    public AudioSource doorAudio;
    public Animator fadeToBlack;

    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            
            secretEnding.SetActive(true);
            doorAnim.SetBool("openDoor", true);
            doorAudio.Play();
            
            
        }
    }

    
}
