﻿using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public static int blubColor;
	public static bool activeLerp;

	public static int BLUE = 1;
	public static int RED = 2;
	public static int YELLOW = 3;
	public static int GREEN = 4;

	public GameObject paint;
	public bool dropPaintNow = false;
	public static int amountOfPaint;

	public string direction = null;
	public string oldDirection;
	public bool wallHit = false;
	private float wallHitTimer = 0.5f;

	private Rigidbody2D rigid;
	private Animator anim;

	void Start()
	{
		blubColor = 0;
		paint.GetComponent<SpriteRenderer> ().color = Color.white;
		rigid = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
	}

	void Update()
	{
		DropPaint ();
		Teleport ();
		LerpPosition ();
		CharacterAnimations ();

		if (wallHit == true) {
			wallHitTimer -= Time.deltaTime;
			if (wallHitTimer < 0) {
				wallHit = false;
				wallHitTimer = 0.5f;
			}
		}
	}

	void CharacterAnimations()
	{
		Vector2 displacement = new Vector2(rigid.velocity.x + transform.position.x, rigid.velocity.y + transform.position.y);
		float yDelta = displacement.y - transform.position.y;
		float xDelta = displacement.x - transform.position.x;
		float degrees = Mathf.Atan2 (yDelta, xDelta) * 180 / Mathf.PI;
		degrees = degrees % 360;
		if (degrees < 0) {
			degrees = degrees + 360;
		}

		//up
		if (degrees >= 45.0f && degrees < 135.0f) 
		{
			anim.SetBool ("Up", true);
			anim.SetBool ("Down", false);
			anim.SetBool ("Left", false);
			anim.SetBool ("Right", false);

			if (wallHit == true) {
				anim.SetBool ("WallHit", wallHit);
			} else {
				anim.SetBool ("WallHit", false);
			}
		}

		//left
		if (degrees >= 135.0f && degrees < 225.0f) 
		{
			anim.SetBool ("Up", false);
			anim.SetBool ("Down", false);
			anim.SetBool ("Left", true);
			anim.SetBool ("Right", false);

			if (wallHit == true) {
				anim.SetBool ("WallHit", wallHit);
			} else {
				anim.SetBool ("WallHit", false);
			}
		}

		//down
		if (degrees >= 225.0f && degrees < 315.0f) 
		{
			anim.SetBool ("Up", false);
			anim.SetBool ("Down", true);
			anim.SetBool ("Left", false);
			anim.SetBool ("Right", false);

			if (wallHit == true) {
				anim.SetBool ("WallHit", wallHit);
			} else {
				anim.SetBool ("WallHit", false);
			}
		}

		//right
		if ((degrees >= 315.0f && degrees <= 360.0f) || (degrees >= 0 && degrees < 45)) 
		{
			anim.SetBool ("Up", false);
			anim.SetBool ("Down", false);
			anim.SetBool ("Left", false);
			anim.SetBool ("Right", true);

			if (wallHit == true) {
				anim.SetBool ("WallHit", wallHit);
			} else {
				anim.SetBool ("WallHit", false);
			}
		}

		anim.SetFloat ("Velocity", rigid.velocity.magnitude);

	}

	void DropPaint()
	{
		//change the dropPaintNow boolean to true or false
		if (gameObject.GetComponent<Rigidbody2D> ().velocity.magnitude > 0.75f)
		{
			dropPaintNow = true;
		}

		else
		{
			dropPaintNow = false;
		}

		//if dropPaintNow = true, drop paint, and reduce amountOfPaint
		if (dropPaintNow == true) 
		{
			Instantiate (paint, transform.position, Quaternion.identity);
			amountOfPaint -= 1;
		}

		else 
		{
			amountOfPaint -= 0;
		}

		if (amountOfPaint <= 0) 
		{
			blubColor = 0;
			gameObject.GetComponent<SpriteRenderer> ().color = Color.white;
			paint.GetComponent<SpriteRenderer> ().color = Color.white;
			amountOfPaint = 0;
		}
	}

	void LerpPosition()
	{
		activeLerp = false;

		if (gameObject.transform.position.x < -6.25f) 
		{
			activeLerp = true;
		}

		if (gameObject.transform.position.x > 6.25f) 
		{
			activeLerp = true;
		}

		if (gameObject.transform.position.y > 2.25f) 
		{
			activeLerp = true;
		}

		if (gameObject.transform.position.y < -2.25f) 
		{
			activeLerp = true;
		}
	}

	void Teleport()
	{
		//teleporting player
		Vector2 playerPosition = gameObject.transform.position;
		if (gameObject.transform.position.x < -8.2f) 
		{
			gameObject.GetComponent<Transform>().position = new Vector2(8.15f, playerPosition.y);
		}

		if (gameObject.transform.position.x > 8.2f) 
		{
			gameObject.GetComponent<Transform>().position = new Vector2(-8.15f, playerPosition.y);
		}

		if (gameObject.transform.position.y > 4.4f) 
		{
			gameObject.GetComponent<Transform>().position = new Vector2(playerPosition.x, -4.35f);
		}

		if (gameObject.transform.position.y < -4.4f) 
		{
			gameObject.GetComponent<Transform>().position = new Vector2(playerPosition.x, 4.35f);
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "BluePaint") 
		{
			gameObject.GetComponent<SpriteRenderer> ().color = new Color (0.0f, 1.0f, 1.0f, 1.0f);
			paint.GetComponent<SpriteRenderer> ().color = new Color (0.0f, 1.0f, 1.0f, 1.0f);
			blubColor = 1;
			amountOfPaint = 300;
		}

		if (other.gameObject.tag == "RedPaint") 
		{
			gameObject.GetComponent<SpriteRenderer> ().color = new Color (1.0f, 0.0f, 0.0f, 1.0f);
			paint.GetComponent<SpriteRenderer> ().color = Color.red;
			blubColor = 2;
			amountOfPaint = 300;
		}

		if (other.gameObject.tag == "YellowPaint") 
		{
			gameObject.GetComponent<SpriteRenderer> ().color = Color.yellow;
			paint.GetComponent<SpriteRenderer> ().color = Color.yellow;
			blubColor = 3;
			amountOfPaint = 300;
		}

		if (other.gameObject.tag == "GreenPaint") 
		{
			gameObject.GetComponent<SpriteRenderer> ().color = Color.green;
			paint.GetComponent<SpriteRenderer> ().color = Color.green;
			blubColor = 4;
			amountOfPaint = 300;
		}

		if (other.gameObject.tag == "Wall") 
		{
			wallHit = true;
		}
	}
}
