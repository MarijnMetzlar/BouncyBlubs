using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public static int blubColor;
	public static bool activeLerp;

	public GameObject paint;
	public bool dropPaintNow = false;
	public static int amountOfPaint;

	void Start()
	{
		blubColor = 0;
		paint.GetComponent<SpriteRenderer> ().color = Color.white;
	}

	void Update()
	{
		DropPaint ();
		Teleport ();
		LerpPosition ();
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
	}
}
