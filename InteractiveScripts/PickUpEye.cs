using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpEye : MonoBehaviour
{

    public PlayerController playerController;

    public GameObject glassEye;

    public bool insideCollider = false;
    public bool hasPickedUpEye = false;

    public Text pickupText;
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && insideCollider == true)
        {
            playerController.HasGlassEye = true;
            hasPickedUpEye = true;
            Destroy(this.gameObject);

            if(hasPickedUpEye == true)
            {
                glassEye.SetActive(true);
            }
        }
    }
    // Start is called before the first frame update
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            pickupText.enabled = true;
            insideCollider = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        pickupText.enabled = false;
    }

}
