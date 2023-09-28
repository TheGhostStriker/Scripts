using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLastDoor : MonoBehaviour
{
    public Animator doorAnim;
    public GameObject keyObject;
    public GameObject keyInObject;
    public AudioSource keyAudio;
    public AudioSource doorAudio;
    public GameObject cursorImage;
    public GameObject handImage;
    public Animator statueMove;
    public GameObject finalTrigger;
    public ParticleSystem dustPart;
    public AudioSource statueRumble;
    public GameObject secretTrigger;
    
   // public GameObject purpleLight;
    //public GameObject redLight;
    // Start is called before the first frame update


    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FinalKey"))
        {
            statueRumble.Play();
            statueMove.SetBool("finalMove", true);
            keyObject.SetActive(false);
            keyInObject.SetActive(true);
            cursorImage.SetActive(true);
            handImage.SetActive(false);
            keyAudio.Play();
            dustPart.Play();
            secretTrigger.SetActive(false);
            
           // purpleLight.SetActive(true);
           // redLight.SetActive(false);

            finalTrigger.SetActive(true);

            Invoke("DoorOpen", 13f);

        }
    }

    private void DoorOpen()
    {
        dustPart.Stop();
        doorAnim.SetBool("openDoor", true);
        doorAudio.Play();
    }
}
