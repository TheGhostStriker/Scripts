using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarKillPlayer : MonoBehaviour
{
    public HealthBar healthBar;
    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            SceneManager.LoadScene("FirstStage");
        }
    }
}
