using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {


	public void LoadLevel(string name)
	{
		Brick.BricksLeft = 0;
		Application.LoadLevel(name);
	}

	public void LoadNextLevel()
	{
		Application.LoadLevel(Application.loadedLevel + 1);
	}

	public void BrickDestroyed()
	{
		if(Brick.BricksLeft <= 0)
		{
			LoadNextLevel();
			Brick.BricksLeft = 0;
		}
	}

	public void QuitRequest()
	{
		Application.Quit ();
	}
}
