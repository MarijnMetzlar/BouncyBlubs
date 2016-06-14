using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Controls : MonoBehaviour {

	private Vector2 mousePosition;
	private Vector2 slingPosition = Vector2.zero;

	public bool shootMode = false;

	public static bool startTimer;
	public static int shots;

	public static float blubSpeed;

	public GameObject player;
	public GameObject sling;
	public GameObject pointer;
	public GameObject arrow;

	public static int shootCounter = 0;

	public float winningTimer = 1.0f;
	public int winningScore;
	public int score = 0;
	public GameObject theLevel;

	public Canvas scoreScreen;
	public Canvas totalScreen;
	public Canvas quitScreen;

	public GameObject screenFader;

	public Camera cam;
	private Vector3 camStartPosition;
	private Vector2 smoothToSlingPosition;
	public int makingCameraSmooth = 0;

	private float _timeStartedLerping;
	private float timeTakenDuringLerp = 2.0f;

	private bool startFadingNow = false;
	private bool replayLevel = false;
	private bool nextLevel = false;
	private bool toWorld = false;

	//for finding the completedLevels
	public static bool completedLevel1 = false;
	public static bool completedLevel2 = false;
	public static bool completedLevel3 = false;
	public static bool completedLevel4 = false;
	public static bool completedLevel5 = false;
	public static bool completedLevel6 = false;

	public List<ColorChip> colorChips;

	void Start()
	{
		cam = Camera.main;
		camStartPosition = cam.transform.localPosition;
	}

	void Update()
	{
		gameObject.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -1);

		mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
		mousePosition = Camera.main.ScreenToWorldPoint (mousePosition);

		SpeedOfThePlayer ();

		//home and back button register
		if (Input.GetKeyDown (KeyCode.Escape)) 
		{
			quitScreen.GetComponent<Canvas> ().enabled = true;
		}

		//PowerUps
		if (PowerUps.speedPowerUpShots <= 0) 
		{
			PowerUps.gotSpeed = false;
			PowerUps.speedPowerUp = 1.0f;
			PowerUps.speedPowerUpShots = 3;
		}

		if (PowerUps.noBouncePowerUpShots <= 0) 
		{
			PowerUps.noBouncePowerUpShots = 3;
			PowerUps.gotNoBounce = false;
		}

		if (PowerUps.ghostPowerUpShots <= 0) 
		{
			PowerUps.gotGhost = false;
			PowerUps.ghostPowerUpShots = 2;
			Color oldColor = player.GetComponent<SpriteRenderer> ().color;
			player.GetComponent<SpriteRenderer> ().color = new Color (oldColor.r, oldColor.g, oldColor.b, 1.0f);
		}

		if (startFadingNow == true) 
		{
			ClickedOnButton ();
		}

		LerpCamera ();
		ShowScoreScreen ();
	}

	void SpeedOfThePlayer()
	{
		//speed of the player
		blubSpeed = Sling.playerDistance * 400.0f * PowerUps.speedPowerUp;

		if (Sling.playerDistance > 2.0f) 
		{
			blubSpeed = 800.0f * PowerUps.speedPowerUp;
		}
	}

	void OnMouseDown()
	{
		makingCameraSmooth = 1;
		_timeStartedLerping = Time.time;

		if (shootMode == false) 
		{
			shootMode = true;
			Instantiate (sling, mousePosition, Quaternion.identity);
			Instantiate (pointer, mousePosition, Quaternion.identity);
			Instantiate (arrow, transform.position, Quaternion.identity);
		}

		if (startTimer == false) 
		{
			startTimer = true;
		}

		//powerUps
		if (PowerUps.gotGhost == true) 
		{
			PowerUps.ghostPowerUpShots -= 1;
		}
	}

	void OnMouseUp()
	{
		slingPosition = new Vector2 (GameObject.FindGameObjectWithTag ("Sling").transform.position.x, GameObject.FindGameObjectWithTag ("Sling").transform.position.y);

		makingCameraSmooth = 0;
		shots += 1;

		if (shootMode == true) 
		{
			shootMode = false;
			shootCounter += 1;
			Destroy(GameObject.FindGameObjectWithTag("Sling"));
			Destroy(GameObject.FindGameObjectWithTag("Pointer"));
			Destroy(GameObject.FindGameObjectWithTag("Arrow"));
			player.GetComponent<Rigidbody2D> ().AddForce ((transform.position - new Vector3( slingPosition.x, slingPosition.y, 0)) * blubSpeed);

			//powerUps
			if (PowerUps.gotSpeed == true) 
			{
				PowerUps.speedPowerUpShots -= 1;
			}

			if (PowerUps.gotNoBounce == true) 
			{
				PowerUps.noBouncePowerUpShots -= 1;
			}
		}
	}

	void LerpCamera()
	{
		//camera lerp to positions
		float timeSinceStarted = Time.time - _timeStartedLerping;
		float percentageComplete = timeSinceStarted / timeTakenDuringLerp;

		//position to lerp to
		if (makingCameraSmooth == 0) 
		{
			cam.transform.position = Vector3.Lerp(cam.transform.position, camStartPosition, Mathf.Pow(percentageComplete, 0.5f));
		}

		else if (makingCameraSmooth == 1 && Player.activeLerp == true) 
		{
			smoothToSlingPosition = GameObject.FindGameObjectWithTag ("Sling").transform.position;
			cam.transform.position = Vector3.Lerp(camStartPosition, new Vector3(smoothToSlingPosition.x, smoothToSlingPosition.y, -10.0f) / 6f, Mathf.Pow(percentageComplete, 0.5f));
		}
	}

	//Canvas Screens inGame
	public void BackToMain()
	{
		SceneManager.LoadScene (sceneBuildIndex:1);
	}

	public void BackToGame()
	{
		quitScreen.GetComponent<Canvas> ().enabled = false;
	}

	//CompleteScreen
	void ShowScoreScreen()
	{
		score = 0;
		foreach (var chip in colorChips) {
			if (chip.IsCorrect)
				score++;
		}

		if (score == winningScore) {
			winningTimer -= Time.deltaTime;
			if (winningTimer < 0) {
				if (score == winningScore) {
					theLevel.SetActive (false);
					startTimer = false;
					winningTimer = 1.0f;

					if (startFadingNow == false) {
						scoreScreen.GetComponent<Canvas> ().enabled = true;
					}

					if (SceneManager.GetActiveScene ().buildIndex == 3) {
						completedLevel1 = true;
					} else if (SceneManager.GetActiveScene ().buildIndex == 4) {
						completedLevel2 = true;
					} else if (SceneManager.GetActiveScene ().buildIndex == 5) {
						completedLevel3 = true;
					} else if (SceneManager.GetActiveScene ().buildIndex == 6) {
						completedLevel4 = true;
					} else if (SceneManager.GetActiveScene ().buildIndex == 7) {
						completedLevel5 = true;
					} else if (SceneManager.GetActiveScene ().buildIndex == 8) {
						completedLevel6 = true;
					}
				}
			}
		} else {
			winningTimer = 1.0f;
		}
	}

	public void ReplayButton()
	{
		startFadingNow = true;
		replayLevel = true;
	}

	public void NextButton()
	{
		startFadingNow = true;
		nextLevel = true;
	}

	public void MenuButton()
	{
		startFadingNow = true;
		toWorld = true;
	}

	void ClickedOnButton()
	{
		totalScreen.enabled = false;
		scoreScreen.enabled = false;
		screenFader.GetComponent<ScreenFade> ().FadeIn ();

		if (ScreenFade.fadeInIsOver == true) 
		{
			if (replayLevel == true) 
			{
				PowerUps.gotSpeed = false;
				PowerUps.gotNoBounce = false;
				PowerUps.gotGhost = false;
				shootCounter = 0;
				Player.amountOfPaint = 0;
				SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
			}

			if (nextLevel == true) 
			{
				PowerUps.gotSpeed = false;
				PowerUps.gotNoBounce = false;
				PowerUps.gotGhost = false;
				PowerUps.speedPowerUpShots = 0;
				PowerUps.noBouncePowerUpShots = 0;
				PowerUps.ghostPowerUpShots = 0;
				shootCounter = 0;
				Player.amountOfPaint = 0;
				SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
			}

			if (toWorld == true) 
			{
				PowerUps.gotSpeed = false;
				PowerUps.gotNoBounce = false;
				PowerUps.gotGhost = false;
				PowerUps.speedPowerUpShots = 0;
				PowerUps.noBouncePowerUpShots = 0;
				PowerUps.ghostPowerUpShots = 0;
				shootCounter = 0;
				Player.amountOfPaint = 0;
				SceneManager.LoadScene (sceneBuildIndex: 1);
			}
		}
	}
}