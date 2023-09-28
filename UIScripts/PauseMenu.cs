using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject Canvas;
    public Image resumeImage;
    public Text resumeText;

    public bool isComicActive = false;
    public bool Paused = false;
    public bool initialPause = true;
    
    // Start is called before the first frame update
    private void Start()
    {
        Canvas.gameObject.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && isComicActive == false)
        {
            if(Paused == true)
            {
                if(initialPause)
                {
                    Resume();
                }
                

            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        initialPause = false;
        Paused = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 1.0f;
        resumeImage.enabled = false;
        resumeText.enabled = false;
        Canvas.gameObject.SetActive(false);

    }

    public void Pause()
    {
        initialPause = true;
        Time.timeScale = 0.0f;
        Canvas.gameObject.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        Paused = true;
    }

    public void Restart(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        Time.timeScale = 1.0f;
    }

    public void Quit(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        Time.timeScale = 1.0f;
    }
}
