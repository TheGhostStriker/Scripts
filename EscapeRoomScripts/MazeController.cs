using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeController : MonoBehaviour
{

    public bool gamePlay = false;
    public AudioSource mazeAudio;

   // public AudioClip rollAudio = null;
   // public AudioClip jumpAudio = null;
   // public AudioClip descendAudio = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gamePlay == true)
        {
            
            Rigidbody rb = GetComponent<Rigidbody>();
            if (Input.GetKey(KeyCode.A))
            {
                if (!mazeAudio.isPlaying)
                {
                    mazeAudio.Play();
                }

                rb.AddForce(Vector3.back);
                rb.useGravity = true;

               // if (!m_audioSource.isPlaying)
               // {
                 //   m_audioSource.PlayOneShot(rollAudio);
                //}
            }

            if (Input.GetKey(KeyCode.D))
            {
                rb.AddForce(Vector3.forward);
                rb.useGravity = true;

               
            }

            if (Input.GetKey(KeyCode.W))
            {
                
                rb.AddForce(Vector3.up);
                rb.useGravity = false;
               // if (!m_audioSource.isPlaying)
               // {
                //    m_audioSource.PlayOneShot(jumpAudio);
               // }
                
            }

            if (Input.GetKey(KeyCode.S))
            {
                rb.AddForce(Vector3.down);
                rb.useGravity = true;
               // if (!m_audioSource.isPlaying)
               // {
                  //  m_audioSource.PlayOneShot(descendAudio);
               // }
            }
        }
        
    }
}
