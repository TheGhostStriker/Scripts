using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakItemToFindKey : MonoBehaviour
{

    [SerializeField] public Transform explosionPosition;

    [SerializeField] public Transform[] brokenPieces;

    public float delayTime = 2f;
    public AudioSource m_audio;
    public GameObject linkedObject;
    public GameObject brokenObject;
    public bool breakable = true;
    public Transform player;
    public Transform breakTrigger;
    public float distance;
    public float activateDistance = 5f;
    public ParticleSystem particleSystem;
    public GameObject keyObject;
    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(player.position, breakTrigger.position);

        if (breakable)
        {
            //GetComponent<MeshRenderer>().enabled = false;
            //GetComponent<Collider>().enabled = false;

            for (int i = 0; i < brokenPieces.Length; i++)
            {
                brokenPieces[i].gameObject.SetActive(true);
                brokenPieces[i].transform.SetParent(null);

                if (brokenPieces[i].GetComponent<Rigidbody>() != null) brokenPieces[i].GetComponent<Rigidbody>().AddExplosionForce(200f, explosionPosition.position, 30f);
            }
            delayTime += Time.deltaTime;

            if (delayTime >= 0f)
            {
                gameObject.SetActive(false);
            }
        }
    }

    public void OnMouseDown()
    {

        if (distance <= activateDistance)

        {
            particleSystem.Play();
            m_audio.Play();
            linkedObject.SetActive(false);
            brokenObject.SetActive(true);
            keyObject.SetActive(true);
        }

    }


}
