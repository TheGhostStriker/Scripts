using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneToMainScreen : MonoBehaviour
{
    public void Awake()
    {
        Invoke("GoToStageOne", 49f);

    }

    public void GoToStageOne()
    {
        SceneManager.LoadScene("FirstStage");
    }
}
