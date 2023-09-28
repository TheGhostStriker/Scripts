using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirtualCamTest : MonoBehaviour
{
    public GameObject virtualCam1;
    public GameObject virtualCam2;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.L))
        {
            virtualCam1.SetActive(false);
            
        }
        if(Input.GetKeyDown(KeyCode.K))
        {
            virtualCam1.SetActive(true);
        }
    }
}
