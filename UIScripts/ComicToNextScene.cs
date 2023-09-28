using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ComicToNextScene : MonoBehaviour
{
    public PauseMenu pauseMenu;
   public void OnButtonPressed()
    {
        pauseMenu.isComicActive = false;
        SceneManager.LoadScene("ToBeContinued");
    }
}
