using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnImageOnPause : MonoBehaviour
{
    public Image menuImage;
    public Text textImage;
    // Start is called before the first frame update
    public void OnPointerEnter()
    {
        menuImage.enabled = true;
        textImage.enabled = true;
        Debug.Log("MouseHasEntered");
    }

    public void OnPointerExit()
    {
        textImage.enabled = false;
        menuImage.enabled = false;
    }
}
