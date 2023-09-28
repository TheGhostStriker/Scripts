using UnityEngine;
using System.Collections;

public class OnHitAddPoints : MonoBehaviour 
{
	public int points;


	public void OnHit()
	{
		GameObject.Find ("Score").GetComponent<Score>().AddPoints (points);
	}
}
