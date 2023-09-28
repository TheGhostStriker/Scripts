using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComicButtonScript : MonoBehaviour
{

    public GameObject comicCam1;
    public GameObject comicCam2;
    

    
    

    public GameObject button1;
    public GameObject button2;

    
        

    public void OnButtonpress()
    {
        button1.SetActive(false);
        comicCam1.SetActive(false);
        comicCam2.SetActive(true);
        
        Invoke("SpawnSecondButton", 3f);
    }

    public void SpawnSecondButton()
    {
        button2.SetActive(true);
    }

  
}
