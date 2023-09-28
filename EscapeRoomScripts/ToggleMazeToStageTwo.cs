using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleMazeToStageTwo : MonoBehaviour
{
    public GameObject mazeStage1;
    public GameObject mazeStage2;
    public AudioSource confirmAudio;
    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("AMazeBall"))
        {
            confirmAudio.Play();
            mazeStage1.SetActive(false);
            mazeStage2.SetActive(true);
        }
    }
}
