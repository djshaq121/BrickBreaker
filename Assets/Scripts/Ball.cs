using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
	private Paddle paddle;
	private Vector3 PaddleToBallVector;
	//We use physics 2d material to "bounce" off the colliders  

	private bool bNotClicked = false;
	// Use this for initialization
	void Start () {
		paddle = GameObject.FindObjectOfType<Paddle> ();
		PaddleToBallVector =  this.transform.position - paddle.transform.position;

		//PaddleToBallVector.magnitude;
	}
	
	// Update is called once per frame
	void Update () {
		
		if(!bNotClicked)
		{
			this.transform.position = paddle.transform.position + PaddleToBallVector;
			if(Input.GetMouseButtonDown(0))
			{
				GetComponent<Rigidbody2D> ().velocity = new Vector2 (2.0f, 10f);
				bNotClicked = true;
			}
		}


	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		Vector2 tweak = new Vector2 (Random.Range(-0.2f,0.4f),Random.Range(-0.2f,0.4f));
		if(bNotClicked)
		{
			GetComponent<AudioSource> ().Play ();
			GetComponent<Rigidbody2D> ().velocity += tweak;

		}
	}
}
