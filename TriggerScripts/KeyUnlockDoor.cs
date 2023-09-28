using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyUnlockDoor : MonoBehaviour
{
    public Animator doorAnim;
    public GameObject keyObject;
    public GameObject keyInObject;
    public AudioSource keyAudio;
    public AudioSource doorAudio;
    public GameObject cursorImage;
    public GameObject handImage;
    public Animator statueAnim;
    public ParticleSystem dustPart;
    public AudioSource statueRumble;
   
    // Start is called before the first frame update


    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Key"))
        {
            statueRumble.Play();
            dustPart.Play();
            keyObject.SetActive(false);
            keyInObject.SetActive(true);
            cursorImage.SetActive(true);
            handImage.SetActive(false);
            keyAudio.Play();
            statueAnim.SetBool("statueRotate", true);



            Invoke("DoorOpen", 11f);

        }
    }

    private void DoorOpen()
    {
        dustPart.Stop();
        statueRumble.Stop();
        doorAnim.SetBool("openDoor", true);
        doorAudio.Play();
    }
}
