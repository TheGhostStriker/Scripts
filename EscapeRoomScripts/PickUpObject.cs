using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObject : MonoBehaviour
{
    public AudioSource pickUpAudio;
    public Transform player;
    public Transform pickupTrigger;
    public float distance;
    public float activateDistance = 5f;
    public Transform pickUpSpot;
    public GameObject handImage;
    public GameObject cursorImage;
    public bool isPickedUp = false;


    void Update()
    {
        distance = Vector3.Distance(player.position, pickupTrigger.position);
    }

    private void OnMouseEnter()
    {
        if (distance <= activateDistance)
        {
            handImage.gameObject.SetActive(true);
            cursorImage.gameObject.SetActive(false);
        }
    }

    private void OnMouseExit()
    {
        handImage.gameObject.SetActive(false);
        cursorImage.gameObject.SetActive(true);
    }
    void OnMouseDown()
    {
        if (distance <= activateDistance && isPickedUp == false)
        {
            pickUpAudio.Play();
            GetComponent<SphereCollider>().isTrigger = true;
            GetComponent<Rigidbody>().useGravity = false;
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
           
            this.transform.position = pickUpSpot.position;
            this.transform.parent = GameObject.Find("PickupSpot").transform;
            isPickedUp = true;
        }
        else if (isPickedUp == true)
        {
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            this.transform.parent = null;
            GetComponent<Rigidbody>().useGravity = true;
            GetComponent<SphereCollider>().isTrigger = false;

            isPickedUp = false;
        }
        
    }
            


    //void OnMouseUp()
    //{
        //GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        //this.transform.parent = null;
        //GetComponent<Rigidbody>().useGravity = true;
        //GetComponent<SphereCollider>().enabled = true;
    //}
}
