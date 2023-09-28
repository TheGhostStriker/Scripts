using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameEnd : MonoBehaviour
{
    public UnityStandardAssets.Characters.FirstPerson.FirstPersonController _FPSController = null;
    public AudioSource evilLaugh;
    public GameObject evilHands;
    public Animator fadeToBlack;
    public Animator evilHandAnim;


    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            evilHandAnim.SetBool("evilGrow", true);
            evilLaugh.Play();
            evilHands.SetActive(true);
            Invoke("FadeToBlack", 2f);
            
            Invoke("Outro", 6f);
        }
    }

    public void FadeToBlack()
    {
        fadeToBlack.SetBool("fadeIn", true);
    }
    public void Outro()
    {
        
        SceneManager.LoadScene("TrueEnding");
        _FPSController.m_MouseLook.SetCursorLock(false);
        _FPSController.m_MouseLook.m_rotateViewIsLocked = true;
    }
}
