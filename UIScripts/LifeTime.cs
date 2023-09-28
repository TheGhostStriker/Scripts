using UnityEngine;
using System.Collections;


public class LifeTime : MonoBehaviour 
{
	public float lifeTime;	// how long to live (seconds)


	void Start () 
	{
		Destroy (gameObject, lifeTime);
	}	
}
