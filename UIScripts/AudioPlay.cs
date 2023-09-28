using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlay : MonoBehaviour
{
    public AudioSource m_music;
    // Start is called before the first frame update
    void Awake()
    {
        m_music.Play(0);
    }

    
}
