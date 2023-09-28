using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyUnlockDoor1 : MonoBehaviour
{
    
    public GameObject keyObject;
    public GameObject keyInObject;
    public AudioSource keyAudio;
    public AudioSource doorAudio;
    public GameObject cursorImage;
    public GameObject handImage;
    public GameObject doorTrigger;
    public AudioSource statueRumble;

    //public GameObject purpleLight;
    //public GameObject redLight;
    public Animator statueAnimate;

    public ParticleSystem dustPart;
    // Start is called before the first frame update


    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("LibraryKey"))
        {
            dustPart.Play();
            statueAnimate.SetBool("rotateAgain", true);
            statueRumble.Play();
            keyObject.SetActive(false);
            keyInObject.SetActive(true);
            cursorImage.SetActive(true);
            handImage.SetActive(false);
            keyAudio.Play();
            doorTrigger.SetActive(true);
            // purpleLight.SetActive(true);
            // redLight.SetActive(false);
            Invoke("ParticlesStop", 20f);
            

        }
    }

    public void ParticlesStop()
    {
        dustPart.Stop();
    }

}
