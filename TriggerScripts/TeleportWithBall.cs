using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportWithBall : MonoBehaviour
{

    public float distance;
    public float activateDistance;

    public UnityStandardAssets.Characters.FirstPerson.FirstPersonController _FPSController = null;

    public Transform player;
    public Transform teleportObject;
    public Transform teleportTarget;
    public GameObject thePlayer;
    public Animator teleportAnimation;
    public AudioSource tpAudio;
    public AudioSource tpCancelAudio;


    public void Update()
    {
        distance = Vector3.Distance(player.position, teleportObject.position);
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("LibraryKey"))
        {
            if (!tpAudio.isPlaying)
            {
                tpAudio.Play();
            }

            _FPSController.GetComponent<CharacterController>().enabled = false;
            _FPSController.m_MouseLook.m_rotateViewIsLocked = true;
            teleportObject.GetComponent<BoxCollider>().enabled = false;
            
            teleportAnimation.SetBool("tpme", true);
            //teleportAnimation.GetComponent<Animator>().enabled = true;
            tpCancelAudio.Stop();

            Invoke("Teleport", 6f);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("LibraryKey"))
        {
            teleportObject.GetComponent<BoxCollider>().enabled = true;
            teleportAnimation.SetBool("tpme", false);
            
            //teleportAnimation.GetComponent<Animator>().enabled = false;
            tpAudio.Stop();
            tpCancelAudio.Play();
            CancelInvoke("Teleport");
        }
    }

    void Teleport()
    {
        _FPSController.m_MouseLook.SetCursorLock(true);
        _FPSController.m_MouseLook.m_rotateViewIsLocked = false;
        _FPSController.GetComponent<CharacterController>().enabled = true;
        thePlayer.transform.position = teleportTarget.transform.position;

    }

}
