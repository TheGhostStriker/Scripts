using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButtonScript : MonoBehaviour
{
    public GameObject vc1;
    public GameObject vc2;
    public GameObject characterUI;
    public GameObject menuUI;
    public GameObject playerCharacter;

    public void OnButtonClicked()
    {
        vc1.SetActive(false);
        vc2.SetActive(true);
        menuUI.SetActive(false);
        playerCharacter.SetActive(true);
        Invoke("SwitchUI", 2f);
    }

    public void SwitchUI()
    {
        characterUI.SetActive(true);
    }


    
}
