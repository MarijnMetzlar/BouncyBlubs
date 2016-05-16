using UnityEngine;
using System.Collections;

public class WhiteYellowFloor : MonoBehaviour {

	public Sprite blueYellowSquare;
	public Sprite redYellowSquare;
	public Sprite greenYellowSquare;
	public Sprite correctYellowSquare;

	public static int yellowCorrect = 0;

	void OnTriggerStay2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player") 
		{
			if (Player.blubColor == 1) //Player with color blue
			{
				gameObject.GetComponent<SpriteRenderer> ().sprite = blueYellowSquare;
				yellowCorrect = 0;
			}

			if (Player.blubColor == 2) //Player with color red
			{
				gameObject.GetComponent<SpriteRenderer> ().sprite = redYellowSquare;
				yellowCorrect = 0;
			}

			if (Player.blubColor == 3) //Player with color yellow
			{
				gameObject.GetComponent<SpriteRenderer> ().sprite = correctYellowSquare;
				yellowCorrect = 1;
			}

			if (Player.blubColor == 4) //Player with color green
			{
				gameObject.GetComponent<SpriteRenderer> ().sprite = greenYellowSquare;
				yellowCorrect = 0;
			}
		}
	}
}
