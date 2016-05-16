using UnityEngine;
using System.Collections;

public class WhiteGreenFloor : MonoBehaviour {

	public Sprite blueGreenSquare;
	public Sprite redGreenSquare;
	public Sprite yellowGreenSquare;
	public Sprite correctGreenSquare;

	public static int greenCorrect = 0;

	void OnTriggerStay2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player") 
		{
			if (Player.blubColor == 1) //Player with color blue
			{
				gameObject.GetComponent<SpriteRenderer> ().sprite = blueGreenSquare;
				greenCorrect = 0;
			}

			if (Player.blubColor == 2) //Player with color red
			{
				gameObject.GetComponent<SpriteRenderer> ().sprite = redGreenSquare;
				greenCorrect = 0;
			}

			if (Player.blubColor == 3) //Player with color yellow
			{
				gameObject.GetComponent<SpriteRenderer> ().sprite = yellowGreenSquare;
				greenCorrect = 0;
			}

			if (Player.blubColor == 4) //Player with color green
			{
				gameObject.GetComponent<SpriteRenderer> ().sprite = correctGreenSquare;
				greenCorrect = 1;
			}
		}
	}
}
