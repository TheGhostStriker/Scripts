using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SecretEnd : MonoBehaviour
{
    public UnityStandardAssets.Characters.FirstPerson.FirstPersonController _FPSController = null;
    public Animator fadeToBlack;


    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            fadeToBlack.SetBool("fadeIn", true);
            Invoke("Secret", 5f);
        }
    }

    public void Secret()
    {

        SceneManager.LoadScene("SecretEnding");
        _FPSController.m_MouseLook.SetCursorLock(false);
        _FPSController.m_MouseLook.m_rotateViewIsLocked = true;
    }
}
