using UnityEngine;
using System.Collections;

public class WhiteGreenFloor : ColorChip {

	public Sprite blueGreenSquare;
	public Sprite redGreenSquare;
	public Sprite yellowGreenSquare;
	public Sprite correctGreenSquare;

	void OnTriggerStay2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player") 
		{
			if (Player.blubColor == Player.BLUE) //Player with color blue
			{
				gameObject.GetComponent<SpriteRenderer> ().sprite = blueGreenSquare;
				IsCorrect = false;
			}

			if (Player.blubColor == Player.RED) //Player with color red
			{
				gameObject.GetComponent<SpriteRenderer> ().sprite = redGreenSquare;
				IsCorrect = false;
			}

			if (Player.blubColor == Player.YELLOW) //Player with color yellow
			{
				gameObject.GetComponent<SpriteRenderer> ().sprite = yellowGreenSquare;
				IsCorrect = false;
			}

			if (Player.blubColor == Player.GREEN) //Player with color green
			{
				gameObject.GetComponent<SpriteRenderer> ().sprite = correctGreenSquare;
				IsCorrect = true;
			}
		}
	}
}
