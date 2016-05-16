using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreCollector : MonoBehaviour {

	public Text countText;
	public Text scoreScreenText;

	// Update is called once per frame
	void Update () 
	{
		countText.text = "" + Controls.shootCounter;

		scoreScreenText.text = "SCORE: \n" + Controls.shootCounter;
	}
}
