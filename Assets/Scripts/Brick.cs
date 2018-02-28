using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

	public Sprite[] HitSprites;
	public AudioClip CrackSound;
	public GameObject smoke;

	private int TimesHit;
	private LevelManager levelManager;
	private bool isBreakable;
	public static int BricksLeft = 0;
	// Use this for initialization
	void Start () {

		isBreakable = (this.tag == "Breakable");
		if(isBreakable)
		{
			BricksLeft++;
		}
		TimesHit = 0;
		levelManager = GameObject.FindObjectOfType<LevelManager> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//If the ball passes through the brick you might have to change to OnCollisionExit instead
	void OnCollisionEnter2D(Collision2D collision)
	{
		AudioSource.PlayClipAtPoint (CrackSound, transform.transform.position);
		if(isBreakable)
		{
				HandleHit ();
		}

	}

	void HandleHit()
	{
		TimesHit++;
		if (HitSprites.Length + 1 <= TimesHit) {
			BricksLeft--;
			GameObject SmokePuff = Instantiate (smoke, gameObject.transform.position, Quaternion.identity);
			levelManager.BrickDestroyed ();
			Destroy (gameObject);

		} else {
			LoadSprites();
		}
	}

	void LoadSprites()
	{
		int spriteIndex = TimesHit - 1;
		if (HitSprites [spriteIndex]) {
			this.GetComponent<SpriteRenderer> ().sprite = HitSprites [spriteIndex];
		} else {
			Debug.LogError ("Missing brick sprite");
		}

	}
		
}
