using UnityEngine;
using System.Collections;

public class WhiteBlueFloor : MonoBehaviour {

	public Sprite yellowBlueSquare;
	public Sprite redBlueSquare;
	public Sprite greenBlueSquare;
	public Sprite correctBlueSquare;

	public static int blueCorrect = 0;

	void OnTriggerStay2D (Collider2D other) 
	{
		if (other.gameObject.tag == "Player") 
		{
			if (Player.blubColor == 1) { //Player with color blue
				gameObject.GetComponent<SpriteRenderer> ().sprite = correctBlueSquare;
				blueCorrect = 1;
			}

			if (Player.blubColor == 2) { //Player with color red
				gameObject.GetComponent<SpriteRenderer> ().sprite = redBlueSquare;
				blueCorrect = 0;
			}

			if (Player.blubColor == 3) { //Player with color yellow
				gameObject.GetComponent<SpriteRenderer> ().sprite = yellowBlueSquare;
				blueCorrect = 0;
			}

			if (Player.blubColor == 4) { //Player with color green
				gameObject.GetComponent<SpriteRenderer> ().sprite = greenBlueSquare;
				blueCorrect = 0;
			}
		}
	}
}
