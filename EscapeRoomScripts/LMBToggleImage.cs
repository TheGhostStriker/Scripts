using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LMBToggleImage : MonoBehaviour
{
    public Transform player;
    public Transform instructionObj;
    public float distance;
    public float activateDistance = 5f;
    public GameObject instructionsObject;
    public GameObject instructionImage;
    public GameObject instructionText;
    public GameObject clickMe;


    private void Update()
    {
        distance = Vector3.Distance(player.position, instructionObj.position);
        if (Input.GetKeyDown("q"))
        {
            instructionImage.SetActive(false);
            instructionText.SetActive(false);
            clickMe.SetActive(false);
        }
    }

    private void OnMouseOver()
    {
        if (distance <= activateDistance)
        {
            clickMe.SetActive(true);
        }
    }

    private void OnMouseExit()
    {
        if (distance <= activateDistance)
        {
            clickMe.SetActive(false);
        }
    }


    void OnMouseDown()
    {
        if (distance <= activateDistance)
        {
            instructionText.SetActive(true);
            instructionImage.SetActive(true);
            clickMe.SetActive(false);
        }
    }

   
}
