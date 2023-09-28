using UnityEngine;
using System.Collections;


public class Lives : MonoBehaviour 
{
	public bool setLives = false;	// needs to be true to set the lives at start of the level
	public int startingLives = 3;		// if setting lives, 3 is the number
	public UnityEngine.UI.Image[] livesIcons; 	// the icons location on screen  (NB, this sets max lives displayable)
	public GameObject player;			// the player prefab / the thing to instantiate
	public GameObject playerSpawnPos;	// the place to instantiate
	public string gameOverScene;		// the name of the game over scene to load when lives are no longer available

	private static int lives = 0;
	private static bool updateLivesDisplay = false;
	private GameObject currentPlayer;		// the player that is currently in use (monitoring it for when it's null / dead)


	// Use this for initialization
	void Start () 
	{
		if (setLives) lives = startingLives;
		else
		{
			lives++;	// temp add one, because it'll be taken off us (& we shouldn't lose one going from one scene to the next)
			SpawnPlayer ();
		}
	}


	// Update is called once per frame
	void Update () 
	{
		// see if AddLives was recently called
		if (updateLivesDisplay)
		{
			updateLivesDisplay = false;
			UpdateLivesDisplay();
		}

		if (currentPlayer == null) 
		{
			if (lives > 0)
			{
				SpawnPlayer ();
			}
			else
			{
				Application.LoadLevel (gameOverScene);
			}
		}
	}


	public static void AddLives (int numToAdd)
	{
		lives += numToAdd;
		updateLivesDisplay = true;
	}


	private void UpdateLivesDisplay()
	{
		for (int i = 0; i < lives; ++i)
		{
			// if I have more lives than icons to show them, stop when I'm done showing what I can
			if (i < livesIcons.Length) livesIcons[i].enabled = true;
		}

		for (int i = lives; i < livesIcons.Length; ++i)
		{
			livesIcons[i].enabled = false;
		}
	}


	private void SpawnPlayer()
	{
		currentPlayer = Instantiate (player, playerSpawnPos.transform.position, playerSpawnPos.transform.rotation) as GameObject;
		lives--;
		UpdateLivesDisplay();
	}
}
