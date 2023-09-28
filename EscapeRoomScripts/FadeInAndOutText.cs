using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class FadeInAndOutText : MonoBehaviour
{
    public Text text1;
    public Text text2;
    public Text text3;

    public Animator textFade1;
    public Animator textFade2;
    public Animator textFade3;

    public AudioSource carAudio;
    public AudioSource rainAudio;
    //public AudioSource carDoorAudio;
    public AudioSource doorSlamAudio;
    public AudioSource handCuffAudio;
    public Animator imageFade;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("FadeFirstText", 5f);
        if (!carAudio.isPlaying && !rainAudio.isPlaying)
        {
            carAudio.Play();
            rainAudio.Play();
        }

        Invoke("FadeImageToRevealButton", 3f);
        
    }

    public void FadeImageToRevealButton()
    {
        imageFade.SetBool("Fade", true);
    }

    public void FadeFirstText()
    {
        textFade1.SetBool("fadeMe", false);
        textFade2.SetBool("fadeMe", true);
        Invoke("FadeSecondText", 5f);

    }

    public void FadeSecondText()
    {
        textFade2.SetBool("fadeMe", false);
        
        Invoke("FadeThirdText", 5f);

    }

    public void FadeThirdText()
    {
        textFade3.SetBool("fadeMe", true);
        Invoke("FadeLastText", 5f);
        carAudio.Stop();
        rainAudio.Stop();
        if (!handCuffAudio.isPlaying)
        {
            handCuffAudio.Play();
        }

        


    }

    public void FadeLastText()
    {
        imageFade.SetBool("Fade", false);
        handCuffAudio.Stop();
        textFade3.SetBool("fadeMe", false);
        Invoke("ChangeScene", 10f);
        
        if(!doorSlamAudio.isPlaying)
        {
            doorSlamAudio.Play();
        }
    }

    public void ChangeScene()
    {
        
        SceneManager.LoadScene("TheMansion");
    }


}
