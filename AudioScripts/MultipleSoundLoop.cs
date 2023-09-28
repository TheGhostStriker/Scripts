using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleSoundLoop : MonoBehaviour
{
    public AudioSource bombTimerClip;
    public AudioSource bombExplosionClip;
    // Start is called before the first frame update
    void Start()
    {
        bombTimerClip.Play();
        bombExplosionClip.PlayDelayed(bombTimerClip.clip.length);
    }

  
}
