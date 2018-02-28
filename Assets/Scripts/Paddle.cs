using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	public bool autoPlay = false;
	private Ball ball;
	// Use this for initialization
	void Start () {
		ball = GameObject.FindObjectOfType<Ball> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (!autoPlay) {
			MoveWithMouse ();
		} else {
			AutoPlay ();
		}

	}

	void MoveWithMouse()
	{
		Vector3 PaddlePos = new Vector3(0.5f, transform.position.y,  0);
		float MousePosInBlocks = (Input.mousePosition.x / Screen.width * 16);
		PaddlePos.x = Mathf.Clamp (MousePosInBlocks, 0.5f, 15.5f);
		this.transform.position = PaddlePos;
	}

	void AutoPlay()
	{
		Vector3 PaddlePos = new Vector3(0.5f, transform.position.y,  0);
		Vector3 BallPos = ball.transform.position;
		PaddlePos.x = Mathf.Clamp (BallPos.x, 0.5f, 15.5f);
		this.transform.position = PaddlePos;
	}
}
