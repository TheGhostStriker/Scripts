using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MazeGameMode : MonoBehaviour
{
    public MazeController boolSwitch;
    
    public GameObject playerCharacter;
    //public bool gameStart = false;
    public GameObject gameCamera;
    public GameObject mazeObject;
    public GameObject triggerObject;
    public GameObject instructionText;
    public GameObject playGameText;
    public AudioSource mazeAudio;
    public float distance;
    public float activateDistance;
    public Transform player;
    public Transform mazeTriggerObject;

    // Start is called before the first frame update

    public void Update()
    {

        distance = Vector3.Distance(player.position, mazeTriggerObject.position);

        if (Input.GetKeyDown("r"))
        {
            mazeAudio.Stop();
            playGameText.SetActive(false);
            playerCharacter.SetActive(true);
            gameCamera.SetActive(false);
            //boolSwitch.GetComponent<MazeController>();
            mazeObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
            mazeObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
            boolSwitch.gamePlay = false;
            triggerObject.SetActive(false);
            Invoke("TurnOnTrigger", 4f);
        }
    }
    public void OnMouseOver()
    {
       if(distance <= activateDistance)
        {
            playGameText.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                
                
                playerCharacter.SetActive(false);
                gameCamera.SetActive(true);
                mazeObject.SetActive(true);
                mazeObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
                boolSwitch.GetComponent<MazeController>();
                boolSwitch.gamePlay = true;
                //gameStart = true;
                triggerObject.SetActive(true);
                instructionText.SetActive(true);
                Invoke("TurnInstructionsOff", 3f);
                Invoke("TurnPlayInstructionsOff", 1.0f);
            }
        }
        
    }

    public void OnMouseExit()
    {
        playGameText.SetActive(false);
    }

    public void TurnPlayInstructionsOff()
    {
        playGameText.SetActive(false);
    }

    public void TurnInstructionsOff()
    {
        instructionText.SetActive(false);
    }

    public void TurnOnTrigger()
    {
        //gameStart = false;
        triggerObject.SetActive(true);

        
    }
}
