using UnityEngine;
using System.Collections;


// at the start of the scene, add a life
public class LivesAdd : MonoBehaviour 
{
	public int livesToAdd = 1;	// by default, add one life; but can configure more.


	// Use this for initialization
	void Start () 
	{
		Lives.AddLives(livesToAdd);
	}
}
