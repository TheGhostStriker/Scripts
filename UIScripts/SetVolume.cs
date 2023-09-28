using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SetVolume : MonoBehaviour
{
    public AudioMixer mixer;

    private void Awake()
    {
      //  GameObject[] objs = GameObject.FindGameObjectsWithTag("Volume");

        DontDestroyOnLoad(this.gameObject);

    }
    public void SetLevel (float sliderValue)
    {
        mixer.SetFloat("MainMixer", Mathf.Log10 (sliderValue) * 20 );
    }

    
}
