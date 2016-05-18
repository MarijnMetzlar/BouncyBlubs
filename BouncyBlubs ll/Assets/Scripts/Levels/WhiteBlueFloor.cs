using UnityEngine;
using System.Collections;

public class WhiteBlueFloor : ColorChip {

	public Sprite yellowBlueSquare;
	public Sprite redBlueSquare;
	public Sprite greenBlueSquare;
	public Sprite correctBlueSquare;

	void OnTriggerStay2D (Collider2D other) 
	{
		if (other.gameObject.tag == "Player") 
		{
			if (Player.blubColor == Player.BLUE) { //Player with color blue
				gameObject.GetComponent<SpriteRenderer> ().sprite = correctBlueSquare;
				IsCorrect = true;
			}

			if (Player.blubColor == Player.RED) { //Player with color red
				gameObject.GetComponent<SpriteRenderer> ().sprite = redBlueSquare;
				IsCorrect = false;
			}

			if (Player.blubColor == Player.YELLOW) { //Player with color yellow
				gameObject.GetComponent<SpriteRenderer> ().sprite = yellowBlueSquare;
				IsCorrect = false;
			}

			if (Player.blubColor == Player.GREEN) { //Player with color green
				gameObject.GetComponent<SpriteRenderer> ().sprite = greenBlueSquare;
				IsCorrect = false;
			}
		}
	}
}
