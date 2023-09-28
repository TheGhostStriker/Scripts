using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseAndOpenDoors : MonoBehaviour
{
    public Animator doorAnim;
    public Animator backDoorAnim;

    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            doorAnim.SetBool("trigger", false);
            backDoorAnim.SetBool("backOpen", true);
        }

    }
}
