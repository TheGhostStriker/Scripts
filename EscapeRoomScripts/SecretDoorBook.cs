using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretDoorBook : MonoBehaviour
{
    public AudioSource secretAudio;

    public Animator secretAnimator1;
    public Animator secretAnimator2;

    public Transform player;
    public Transform secretTrigger;
    public float distance;
    public float activateDistance;

    
    public GameObject handImage;
    public GameObject cursorImage;

    private void Update()
    {
        distance = Vector3.Distance(player.position, secretTrigger.position);
    }

    private void OnMouseEnter()
    {
        if(distance <= activateDistance)
        {
            handImage.SetActive(true);
            cursorImage.SetActive(false);
            
        }
    }

    private void OnMouseExit()
    {
        handImage.SetActive(false);
        cursorImage.SetActive(true);
    }

    public void OnMouseDown()
    {
        secretAudio.Play();
        secretAnimator1.SetBool("secretOpen", true);
        secretAnimator2.SetBool("secretOpen", true);
    }
}
