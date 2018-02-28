using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {


	static MusicPlayer Instance;
	void Awake()
	{
		if (Instance != null) {
			Destroy (gameObject);
			print ("Destroyed music player");
		} else {
			Instance = this;
			GameObject.DontDestroyOnLoad (gameObject);
		}
	}

	
	// Update is called once per frame
	void Update () {
		
	}
}
