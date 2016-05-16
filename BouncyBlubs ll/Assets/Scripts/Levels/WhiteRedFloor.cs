using UnityEngine;
using System.Collections;

public class WhiteRedFloor : MonoBehaviour {

	public Sprite blueRedSquare;
	public Sprite yellowRedSquare;
	public Sprite greenRedSquare;
	public Sprite correctRedSquare;

	public static int redCorrect = 0;

	void OnTriggerStay2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player") 
		{
			if (Player.blubColor == 1) { //Player with color blue
				gameObject.GetComponent<SpriteRenderer> ().sprite = blueRedSquare;
				redCorrect = 0;
			}

			if (Player.blubColor == 2) { //Player with color red
				gameObject.GetComponent<SpriteRenderer> ().sprite = correctRedSquare;
				redCorrect = 1;
			}

			if (Player.blubColor == 3) { //Player with color yellow
				gameObject.GetComponent<SpriteRenderer> ().sprite = yellowRedSquare;
				redCorrect = 0;
			}

			if (Player.blubColor == 4) { //Player with color green
				gameObject.GetComponent<SpriteRenderer> ().sprite = greenRedSquare;
				redCorrect = 0;
			}
		}
	}
}
