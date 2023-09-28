using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenControls : MonoBehaviour
{

    public GameObject controlsMenu;
    public GameObject optionMenu;

    public void OnButtonClicked()
    {
        optionMenu.SetActive(false);
        controlsMenu.SetActive(true);
    }

    public void LeaveControls()
    {
        optionMenu.SetActive(true);
        controlsMenu.SetActive(false);
    }
    
}
