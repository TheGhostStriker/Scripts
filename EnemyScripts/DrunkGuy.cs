using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrunkGuy : MonoBehaviour
{
    public float throwVelocity = 10f;
    public float Timer = 2;
    public GameObject beerBottle;
    

    

    private void Update()
    {
        Timer -= 1 * Time.deltaTime;
        if (Timer <= 0f)
        {
            GameObject beer = Instantiate(beerBottle, transform.position, transform.rotation);
            beer.GetComponent<Rigidbody>().AddForce(transform.forward * throwVelocity + Vector3.up * 2f, ForceMode.VelocityChange);
            Destroy(beer, 2f);
            Timer = 2;
        }
    }

    
}
