using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishMaze : MonoBehaviour
{
    public GameObject keyReward;
    public MazeController boolSwitch;
    public GameObject playerCharacter;
    public GameObject mazeTrigger;
    public GameObject ballObject;
    public GameObject mazeCamera;
    public Animator doorAnimation;
    public GameObject eActivate;
    public AudioSource confirmAudio;
    public AudioSource mazeAudio;

    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("AMazeBall"))
        {
            confirmAudio.Play();
            playerCharacter.SetActive(true);
            boolSwitch.GetComponent<MazeController>();
            boolSwitch.gamePlay = false;
            keyReward.SetActive(true);
            mazeTrigger.SetActive(false);
            ballObject.SetActive(false);
            mazeCamera.SetActive(false);
            doorAnimation.SetBool("openDoor", true);
            eActivate.SetActive(false);
            mazeAudio.Stop();
        }
    }
}
