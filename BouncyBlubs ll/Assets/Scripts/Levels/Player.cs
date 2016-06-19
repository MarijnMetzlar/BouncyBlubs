using UnityEngine;
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

	private bool _isTriggered;
	public static int bounces;
	private bool _triggered;

	private Rigidbody2D rigid;
	private Animator anim;

	public GameObject splat;
	private Animator splatAnim;

	private AudioSource allPlayerSounds;
	private int randomNrBounce;
	private int randomNrPaint;
	public AudioClip bounceSound1;
	public AudioClip bounceSound2;
	public AudioClip bounceSound3;
	public AudioClip gettingPaint;

	public GameObject hat;
	public Sprite none;
	public Sprite devilItem;
	public Sprite fezItem;
	public Sprite haloItem;
	public Sprite tophatItem;
	public Sprite cakeHatItem;
	public Sprite diamondCrownItem;
	public Sprite goldenCrownItem;
	public Sprite monocleItem;
	public Sprite pirateHatItem;
	public Sprite poopooHatItem;
	public Sprite silverCrownItem;
	public Sprite wizardHatItem;

	void Start()
	{
		blubColor = 0;
		paint.GetComponent<SpriteRenderer> ().color = Color.white;
		rigid = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
		splatAnim = splat.GetComponent<Animator> ();
		allPlayerSounds = GetComponent<AudioSource> ();
		GetHat ();
	}

	void Update()
	{
		DropPaint ();
		Teleport ();
		LerpPosition ();
		CharacterAnimations ();
		Splat ();

		if (wallHit == true) {
			wallHitTimer -= Time.deltaTime;
			if (wallHitTimer < 0) {
				wallHit = false;
				wallHitTimer = 0.5f;
			}
		}
	}

	void GetHat()
	{
		if (ItemScreen.itemNr == 0) {
			hat.GetComponent<SpriteRenderer> ().sprite = none;
			hat.GetComponent<Transform> ().localPosition = new Vector3 (0.0f, 0.0f, 0.0f);
			hat.GetComponent<Transform> ().localScale = new Vector3 (0.0f, 0.0f, 0.0f);
		}
		if (ItemScreen.itemNr == 1) {
			hat.GetComponent<SpriteRenderer> ().sprite = devilItem;
			hat.GetComponent<Transform> ().localPosition = new Vector3 (0.0f, 0.84f, 0.0f);
			hat.GetComponent<Transform> ().localScale = new Vector3 (1.0f, 1.0f, 1.0f);
		}
		if (ItemScreen.itemNr == 2) {
			hat.GetComponent<SpriteRenderer> ().sprite = fezItem;
			hat.GetComponent<Transform> ().localPosition = new Vector3 (0.0f, 0.84f, 0.0f);
			hat.GetComponent<Transform> ().localScale = new Vector3 (0.93f, 1.02f, 1.0f);
		}
		if (ItemScreen.itemNr == 3) {
			hat.GetComponent<SpriteRenderer> ().sprite = haloItem;
			hat.GetComponent<Transform> ().localPosition = new Vector3 (0.0f, 0.75f, 0.0f);
			hat.GetComponent<Transform> ().localScale = new Vector3 (0.93f, 1.02f, 1.0f);
		}
		if (ItemScreen.itemNr == 4) {
			hat.GetComponent<SpriteRenderer> ().sprite = tophatItem;
			hat.GetComponent<Transform> ().localPosition = new Vector3 (-0.15f, 0.84f, 0.0f);
			hat.GetComponent<Transform> ().localScale = new Vector3 (0.93f, 1.02f, 1.0f);
		}
		if (ItemScreen.itemNr == 5) {
			hat.GetComponent<SpriteRenderer> ().sprite = cakeHatItem;
			hat.GetComponent<Transform> ().localPosition = new Vector3 (0.0f, 1.1f, 0.0f);
			hat.GetComponent<Transform> ().localScale = new Vector3 (0.74f, 0.74f, 0.74f);
		}
		if (ItemScreen.itemNr == 6) {
			hat.GetComponent<SpriteRenderer> ().sprite = diamondCrownItem;
			hat.GetComponent<Transform> ().localPosition = new Vector3 (0.0f, 1.0f, 0.0f);
			hat.GetComponent<Transform> ().localScale = new Vector3 (0.8f, 0.88f, 0.86f);
		}
		if (ItemScreen.itemNr == 7) {
			hat.GetComponent<SpriteRenderer> ().sprite = goldenCrownItem;
			hat.GetComponent<Transform> ().localPosition = new Vector3 (0.0f, 0.95f, 0.0f);
			hat.GetComponent<Transform> ().localScale = new Vector3 (0.8f, 0.88f, 0.86f);
		}
		if (ItemScreen.itemNr == 8) {
			hat.GetComponent<SpriteRenderer> ().sprite = monocleItem;
			hat.GetComponent<Transform> ().localPosition = new Vector3 (0.0f, 0.2f, 0.0f);
			hat.GetComponent<Transform> ().localScale = new Vector3 (1.0f, 1.0f, 1.0f);
		}
		if (ItemScreen.itemNr == 9) {
			hat.GetComponent<SpriteRenderer> ().sprite = pirateHatItem;
			hat.GetComponent<Transform> ().localPosition = new Vector3 (0.0f, 0.9f, 0.0f);
			hat.GetComponent<Transform> ().localScale = new Vector3 (1.0f, 1.0f, 1.0f);
		}
		if (ItemScreen.itemNr == 10) {
			hat.GetComponent<SpriteRenderer> ().sprite = poopooHatItem;
			hat.GetComponent<Transform> ().localPosition = new Vector3 (0.0f, 0.95f, 0.0f);
			hat.GetComponent<Transform> ().localScale = new Vector3 (1.0f, 1.0f, 1.0f);
		}
		if (ItemScreen.itemNr == 11) {
			hat.GetComponent<SpriteRenderer> ().sprite = silverCrownItem;
			hat.GetComponent<Transform> ().localPosition = new Vector3 (0.0f, 1.0f, 0.0f);
			hat.GetComponent<Transform> ().localScale = new Vector3 (0.8f, 0.88f, 0.86f);
		}
		if (ItemScreen.itemNr == 12) {
			hat.GetComponent<SpriteRenderer> ().sprite = wizardHatItem;
			hat.GetComponent<Transform> ().localPosition = new Vector3 (0.0f, 0.95f, 0.0f);
			hat.GetComponent<Transform> ().localScale = new Vector3 (1.0f, 1.0f, 1.0f);
		}
	}

	void Splat()
	{
		if (blubColor == 1) 
		{
			if (wallHit == true) 
			{
				splatAnim.SetBool ("BlueBounce", wallHit);
			} 

			else 
			{
				splatAnim.SetBool ("BlueBounce", false);
			}
		}

		else if (blubColor == 2) 
		{
			if (wallHit == true) 
			{
				splatAnim.SetBool ("RedBounce", wallHit);
			} 

			else 
			{
				splatAnim.SetBool ("RedBounce", false);
			}
		} 

		else if (blubColor == 3) 
		{
			if (wallHit == true) 
			{
				splatAnim.SetBool ("YellowBounce", wallHit);
			} 

			else 
			{
				splatAnim.SetBool ("YellowBounce", false);
			}
		} 

		else if (blubColor == 4) 
		{
			if (wallHit == true) 
			{
				splatAnim.SetBool ("GreenBounce", wallHit);
			} 

			else 
			{
				splatAnim.SetBool ("GreenBounce", false);
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
			GameObject _paint = Instantiate (paint, transform.position, Quaternion.identity) as GameObject;
			_paint.transform.parent = GameObject.FindGameObjectWithTag("DroppedPaint").transform;
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
		if (_isTriggered) {
			_isTriggered = false;
			return;
		}

		_isTriggered = true;
		if (other.gameObject.tag == "BluePaint") 
		{
			allPlayerSounds.PlayOneShot (gettingPaint);
			gameObject.GetComponent<SpriteRenderer> ().color = new Color (0.0f, 1.0f, 1.0f, 1.0f);
			paint.GetComponent<SpriteRenderer> ().color = new Color (0.0f, 1.0f, 1.0f, 1.0f);
			blubColor = 1;
			amountOfPaint = 300;
		}

		if (other.gameObject.tag == "RedPaint") 
		{
			allPlayerSounds.PlayOneShot (gettingPaint);
			gameObject.GetComponent<SpriteRenderer> ().color = new Color (1.0f, 0.0f, 0.0f, 1.0f);
			paint.GetComponent<SpriteRenderer> ().color = Color.red;
			blubColor = 2;
			amountOfPaint = 300;
		}

		if (other.gameObject.tag == "YellowPaint") 
		{
			allPlayerSounds.PlayOneShot (gettingPaint);
			gameObject.GetComponent<SpriteRenderer> ().color = Color.yellow;
			paint.GetComponent<SpriteRenderer> ().color = Color.yellow;
			blubColor = 3;
			amountOfPaint = 300;
		}

		if (other.gameObject.tag == "GreenPaint") 
		{
			allPlayerSounds.PlayOneShot (gettingPaint);
			gameObject.GetComponent<SpriteRenderer> ().color = Color.green;
			paint.GetComponent<SpriteRenderer> ().color = Color.green;
			blubColor = 4;
			amountOfPaint = 300;
		}

		if (other.gameObject.tag == "Wall") 
		{
			wallHit = true;
			randomNrBounce = Random.Range (0, 3);

			if (randomNrBounce == 0) {
				allPlayerSounds.PlayOneShot (bounceSound1);
			} else if (randomNrBounce == 1) {
				allPlayerSounds.PlayOneShot (bounceSound2);
			} else if (randomNrBounce == 2) {
				allPlayerSounds.PlayOneShot (bounceSound3);
			}
		}
	}

	void OnTriggerExit2D(Collider2D other)
	{
		if (_triggered) {
			_triggered = false;
			return;
		}

		_triggered = true;
		if (other.gameObject.tag == "Wall") {
			bounces += 1;
		}
	}
}
