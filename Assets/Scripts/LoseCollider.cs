using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {

	private LevelManager levelManager;
	void OnCollisionEnter2D(Collision2D collision)
	{
		
	}

	void OnTriggerEnter2D(Collider2D collision)
	{
		levelManager.LoadLevel("Lose");
	}
	// Use this for initialization
	void Start () {
		levelManager = GameObject.FindObjectOfType<LevelManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
