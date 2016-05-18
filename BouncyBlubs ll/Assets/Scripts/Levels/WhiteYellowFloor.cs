using UnityEngine;
using System.Collections;

public class WhiteYellowFloor : ColorChip {

	public Sprite blueYellowSquare;
	public Sprite redYellowSquare;
	public Sprite greenYellowSquare;
	public Sprite correctYellowSquare;

	void OnTriggerStay2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player") 
		{
			if (Player.blubColor == Player.BLUE) //Player with color blue
			{
				gameObject.GetComponent<SpriteRenderer> ().sprite = blueYellowSquare;
				IsCorrect = false;
			}

			if (Player.blubColor == Player.RED) //Player with color red
			{
				gameObject.GetComponent<SpriteRenderer> ().sprite = redYellowSquare;
				IsCorrect = false;
			}

			if (Player.blubColor == Player.YELLOW) //Player with color yellow
			{
				gameObject.GetComponent<SpriteRenderer> ().sprite = correctYellowSquare;
				IsCorrect = true;
			}

			if (Player.blubColor == Player.GREEN) //Player with color green
			{
				gameObject.GetComponent<SpriteRenderer> ().sprite = greenYellowSquare;
				IsCorrect = false;
			}
		}
	}
}
