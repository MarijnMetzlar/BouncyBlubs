using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreCollector : MonoBehaviour {

	public float maxTime;

	public float winOneStar;
	public float winSecondStar;
	public float winThirdStar;
	public float winFourthStar;
	public float winFifthStar;

	private float currentTime;
	private float totalScore;

	public Text inGameTime;
	public Text totalScoreText;
	public Text remainingTimeText;
	public Text bounceText;
	public Text shotsText;

	public GameObject star1;
	public GameObject star2;
	public GameObject star3;
	public GameObject star4;
	public GameObject star5;

	public Sprite emptyStar;
	public Sprite star;

	// Update is called once per frame
	void Start ()
	{
		currentTime = maxTime;
	}

	void Update () 
	{
		if (Controls.startTimer == true) 
		{
			currentTime -= Time.deltaTime;
		}
			
		inGameTime.text = "" + currentTime.ToString("F1");

		if (currentTime <= 0.0f) 
		{
			currentTime = 0.0f;
			Controls.startTimer = false;
		}

		totalScore = currentTime + Player.bounces - (Controls.shots * 2);

		if (totalScore < 0.0f) 
		{
			totalScore = 0.0f;
		}

		totalScoreText.text = "\n" + "SCORE: " + totalScore.ToString("F1");

		remainingTimeText.text = "Time left: " + currentTime.ToString("F1") + " sec.";
		bounceText.text = "Bounces: " + Player.bounces;
		shotsText.text = "Shots: " + Controls.shots;

		ShowStars ();
	}

	void ShowStars()
	{
		if (totalScore > winOneStar) {
			star1.GetComponent<Image> ().sprite = star;
		} else {
			star1.GetComponent<Image> ().sprite = emptyStar;
		}

		if (totalScore > winSecondStar) {
			star2.GetComponent<Image> ().sprite = star;
		} else {
			star2.GetComponent<Image> ().sprite = emptyStar;
		}

		if (totalScore > winThirdStar) {
			star3.GetComponent<Image> ().sprite = star;
		} else {
			star3.GetComponent<Image> ().sprite = emptyStar;
		}

		if (totalScore > winFourthStar) {
			star4.GetComponent<Image> ().sprite = star;
		} else {
			star4.GetComponent<Image> ().sprite = emptyStar;
		}

		if (totalScore > winFifthStar) {
			star5.GetComponent<Image> ().sprite = star;
		} else {
			star5.GetComponent<Image> ().sprite = emptyStar;
		}
	}
}
