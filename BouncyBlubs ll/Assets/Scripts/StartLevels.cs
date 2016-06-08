using UnityEngine;
using System.Collections;

public class StartLevels : MonoBehaviour {

	public int LevelType;

	void Start()
	{
		ColorThePlaces ();
	}

	void ColorThePlaces()
	{
		if (LevelType == 1) 
		{
			gameObject.GetComponent<SpriteRenderer> ().color = Color.green;
		}

		if (LevelType == 2) 
		{
			if (Controls.completedLevel1 == false) {
				gameObject.GetComponent<SpriteRenderer> ().color = Color.red;
			} else {
				gameObject.GetComponent<SpriteRenderer> ().color = Color.green;
			}
		}

		if (LevelType == 3) 
		{
			if (Controls.completedLevel2 == false) {
				gameObject.GetComponent<SpriteRenderer> ().color = Color.red;
			} else {
				gameObject.GetComponent<SpriteRenderer> ().color = Color.green;
			}
		}

		if (LevelType == 4) 
		{
			if (Controls.completedLevel3 == false) {
				gameObject.GetComponent<SpriteRenderer> ().color = Color.red;
			} else {
				gameObject.GetComponent<SpriteRenderer> ().color = Color.green;
			}
		}

		if (LevelType == 5) 
		{
			if (Controls.completedLevel4 == false) {
				gameObject.GetComponent<SpriteRenderer> ().color = Color.red;
			} else {
				gameObject.GetComponent<SpriteRenderer> ().color = Color.green;
			}
		}

		if (LevelType == 6) 
		{
			if (Controls.completedLevel5 == false) {
				gameObject.GetComponent<SpriteRenderer> ().color = Color.red;
			} else {
				gameObject.GetComponent<SpriteRenderer> ().color = Color.green;
			}
		}

		if (LevelType == 7) 
		{
			if (Controls.completedLevel6 == false) {
				gameObject.GetComponent<SpriteRenderer> ().color = Color.red;
			} else {
				gameObject.GetComponent<SpriteRenderer> ().color = Color.green;
			}
		}
	}
		
	void OnMouseDown()
	{
		if (LevelType == 1) 
		{
			Application.LoadLevel (3);
		}

		if (LevelType == 2 && Controls.completedLevel1 == true) 
		{
			Application.LoadLevel (4);
		}

		if (LevelType == 3 && Controls.completedLevel2 == true) 
		{
			Application.LoadLevel (5);
		}

		if (LevelType == 4 && Controls.completedLevel3 == true) 
		{
			Application.LoadLevel (6);
		}

		if (LevelType == 5 && Controls.completedLevel4 == true) 
		{
			Application.LoadLevel (7);
		}

		if (LevelType == 6 && Controls.completedLevel5 == true) 
		{
			Application.LoadLevel (8);
		}

		if (LevelType == 7 && Controls.completedLevel6 == true) 
		{
			Application.LoadLevel (9);
		}
	}
}
