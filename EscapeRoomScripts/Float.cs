using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Float : MonoBehaviour
{
    public float FloatStrength = 0.1f;
    public float RandomRotationStrength = 0.1f;

    public void Start()
    {
        FloatStrength = Random.Range(0.1f, 0.6f);
        RandomRotationStrength = Random.Range(0.1f, 0.6f);
    }


    void Update()
    {
        transform.GetComponent<Rigidbody>().AddForce(Vector3.up * FloatStrength);
        transform.Rotate(RandomRotationStrength, RandomRotationStrength, RandomRotationStrength);

    }

   
}
