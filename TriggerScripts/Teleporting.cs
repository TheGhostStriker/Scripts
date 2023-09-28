using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Teleporting : MonoBehaviour
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
    public GameObject activateText;

    //public PowerGauntletScript boolSwitching;
    //&& boolSwitching.canTeleport == true
    //public ParticleSystem teleportParticles;
    private void Start()
    {
        
    }

    public void Update()
    {
        
        distance = Vector3.Distance(player.position, teleportObject.position);
    }
    public void OnMouseOver()
    {
        activateText.SetActive(true);

        if (distance <= activateDistance)
        {
            

           
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (!tpAudio.isPlaying)
                {

                    tpAudio.Play();
                }

                _FPSController.GetComponent<CharacterController>().enabled = false;
                _FPSController.m_MouseLook.m_rotateViewIsLocked = true;
                teleportObject.GetComponent<BoxCollider>().enabled = false;
                activateText.SetActive(false);
                teleportAnimation.SetBool("tpme", true);
                //teleportAnimation.GetComponent<Animator>().enabled = true;
                tpCancelAudio.Stop();
                
                Invoke("Teleport", 6f);
            }

            if(distance >= activateDistance)
            {
                activateText.SetActive(false);
            }
        }
        
    }

    private void OnMouseExit()
    {
        
        if (distance <= activateDistance)
        {
            teleportObject.GetComponent<BoxCollider>().enabled = true;
            teleportAnimation.SetBool("tpme", false);
            activateText.SetActive(false);
            //teleportAnimation.GetComponent<Animator>().enabled = false;
            tpAudio.Stop();
            tpCancelAudio.Play();
            CancelInvoke("Teleport");
            
        }

        if(distance > activateDistance)
        {
            activateText.SetActive(false);
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
