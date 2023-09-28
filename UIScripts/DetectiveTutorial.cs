using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DetectiveTutorial : MonoBehaviour
{
    public Text detectiveText;
    // Start is called before the first frame update
    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            detectiveText.enabled = true;
            Invoke("TextTurnOff", 3f);
        }
    }

    public void TextTurnOff()
    {
        detectiveText.enabled = false;
        Destroy(this.gameObject);
    }
}
