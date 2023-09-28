using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnOtherMap : MonoBehaviour
{

    
    public GameObject mansionTwo;
    // Start is called before the first frame update


    public void OnMouseEnter()
    {
        
        
            mansionTwo.SetActive(true);
            
        
    }

   
}
