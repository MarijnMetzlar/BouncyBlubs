using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

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
			if (Controls.completedLevel0_1 == false) {
				gameObject.GetComponent<SpriteRenderer> ().color = Color.red;
			} else {
				gameObject.GetComponent<SpriteRenderer> ().color = Color.green;
			}
		}

		if (LevelType == 3) 
		{
			if (Controls.completedLevel0_2 == false) {
				gameObject.GetComponent<SpriteRenderer> ().color = Color.red;
			} else {
				gameObject.GetComponent<SpriteRenderer> ().color = Color.green;
			}
		}

		if (LevelType == 4) 
		{
			if (Controls.completedLevel0_3 == false) {
				gameObject.GetComponent<SpriteRenderer> ().color = Color.red;
			} else {
				gameObject.GetComponent<SpriteRenderer> ().color = Color.green;
			}
		}

		if (LevelType == 5) 
		{
			if (Controls.completedLevel0_4 == false) {
				gameObject.GetComponent<SpriteRenderer> ().color = Color.red;
			} else {
				gameObject.GetComponent<SpriteRenderer> ().color = Color.green;
			}
		}

		if (LevelType == 6) 
		{
			if (Controls.completedLevel0_5 == false) {
				gameObject.GetComponent<SpriteRenderer> ().color = Color.red;
			} else {
				gameObject.GetComponent<SpriteRenderer> ().color = Color.green;
			}
		}

		if (LevelType == 7) 
		{
			if (Controls.completedLevel0_6 == false) {
				gameObject.GetComponent<SpriteRenderer> ().color = Color.red;
			} else {
				gameObject.GetComponent<SpriteRenderer> ().color = Color.green;
			}
		}

		if (LevelType == 8) 
		{
			if (Controls.completedLevel0_7 == false) {
				gameObject.GetComponent<SpriteRenderer> ().color = Color.red;
			} else {
				gameObject.GetComponent<SpriteRenderer> ().color = Color.green;
			}
		}

		if (LevelType == 9) 
		{
			if (Controls.completedLevel1_1 == false) {
				gameObject.GetComponent<SpriteRenderer> ().color = Color.red;
			} else {
				gameObject.GetComponent<SpriteRenderer> ().color = Color.green;
			}
		}

		if (LevelType == 10) 
		{
			if (Controls.completedLevel1_2 == false) {
				gameObject.GetComponent<SpriteRenderer> ().color = Color.red;
			} else {
				gameObject.GetComponent<SpriteRenderer> ().color = Color.green;
			}
		}

		if (LevelType == 11) 
		{
			if (Controls.completedLevel1_3 == false) {
				gameObject.GetComponent<SpriteRenderer> ().color = Color.red;
			} else {
				gameObject.GetComponent<SpriteRenderer> ().color = Color.green;
			}
		}

		if (LevelType == 12) 
		{
			if (Controls.completedLevel1_4 == false) {
				gameObject.GetComponent<SpriteRenderer> ().color = Color.red;
			} else {
				gameObject.GetComponent<SpriteRenderer> ().color = Color.green;
			}
		}

		if (LevelType == 13) 
		{
			if (Controls.completedLevel1_5 == false) {
				gameObject.GetComponent<SpriteRenderer> ().color = Color.red;
			} else {
				gameObject.GetComponent<SpriteRenderer> ().color = Color.green;
			}
		}

		if (LevelType == 14) 
		{
			if (Controls.completedLevel1_6 == false) {
				gameObject.GetComponent<SpriteRenderer> ().color = Color.red;
			} else {
				gameObject.GetComponent<SpriteRenderer> ().color = Color.green;
			}
		}

		if (LevelType == 15) 
		{
			if (Controls.completedLevel1_7 == false) {
				gameObject.GetComponent<SpriteRenderer> ().color = Color.red;
			} else {
				gameObject.GetComponent<SpriteRenderer> ().color = Color.green;
			}
		}

		if (LevelType == 16) 
		{
			if (Controls.completedLevel1_8 == false) {
				gameObject.GetComponent<SpriteRenderer> ().color = Color.red;
			} else {
				gameObject.GetComponent<SpriteRenderer> ().color = Color.green;
			}
		}

		if (LevelType == 17) 
		{
			if (Controls.completedLevel1_9 == false) {
				gameObject.GetComponent<SpriteRenderer> ().color = Color.red;
			} else {
				gameObject.GetComponent<SpriteRenderer> ().color = Color.green;
			}
		}

		if (LevelType == 18) 
		{
			if (Controls.completedLevel1_10 == false) {
				gameObject.GetComponent<SpriteRenderer> ().color = Color.red;
			} else {
				gameObject.GetComponent<SpriteRenderer> ().color = Color.green;
			}
		}

		if (LevelType == 19) 
		{
			if (Controls.completedLevel2_1 == false) {
				gameObject.GetComponent<SpriteRenderer> ().color = Color.red;
			} else {
				gameObject.GetComponent<SpriteRenderer> ().color = Color.green;
			}
		}

		if (LevelType == 20) 
		{
			if (Controls.completedLevel2_2 == false) {
				gameObject.GetComponent<SpriteRenderer> ().color = Color.red;
			} else {
				gameObject.GetComponent<SpriteRenderer> ().color = Color.green;
			}
		}

		if (LevelType == 21) 
		{
			if (Controls.completedLevel2_3 == false) {
				gameObject.GetComponent<SpriteRenderer> ().color = Color.red;
			} else {
				gameObject.GetComponent<SpriteRenderer> ().color = Color.green;
			}
		}

		if (LevelType == 22) 
		{
			if (Controls.completedLevel2_4 == false) {
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
			SceneManager.LoadScene (sceneBuildIndex:5);
		}

		if (LevelType == 2 && Controls.completedLevel0_1 == true) 
		{
			SceneManager.LoadScene (sceneBuildIndex:6);
		}

		if (LevelType == 3 && Controls.completedLevel0_2 == true) 
		{
			SceneManager.LoadScene (sceneBuildIndex:7);
		}

		if (LevelType == 4 && Controls.completedLevel0_3 == true) 
		{
			SceneManager.LoadScene (sceneBuildIndex:8);
		}

		if (LevelType == 5 && Controls.completedLevel0_4 == true) 
		{
			SceneManager.LoadScene (sceneBuildIndex:9);
		}

		if (LevelType == 6 && Controls.completedLevel0_5 == true) 
		{
			SceneManager.LoadScene (sceneBuildIndex:10);
		}

		if (LevelType == 7 && Controls.completedLevel0_6 == true) 
		{
			SceneManager.LoadScene (sceneBuildIndex:11);
		}

		if (LevelType == 8 && Controls.completedLevel0_7 == true) 
		{
			SceneManager.LoadScene (sceneBuildIndex:12);
		}

		if (LevelType == 9 && Controls.completedLevel1_1 == true) 
		{
			SceneManager.LoadScene (sceneBuildIndex:13);
		}

		if (LevelType == 10 && Controls.completedLevel1_2 == true) 
		{
			SceneManager.LoadScene (sceneBuildIndex:14);
		}

		if (LevelType == 11 && Controls.completedLevel1_3 == true) 
		{
			SceneManager.LoadScene (sceneBuildIndex:15);
		}

		if (LevelType == 12 && Controls.completedLevel1_4 == true) 
		{
			SceneManager.LoadScene (sceneBuildIndex:16);
		}

		if (LevelType == 13 && Controls.completedLevel1_5 == true) 
		{
			SceneManager.LoadScene (sceneBuildIndex:17);
		}

		if (LevelType == 14 && Controls.completedLevel1_6 == true) 
		{
			SceneManager.LoadScene (sceneBuildIndex:18);
		}

		if (LevelType == 15 && Controls.completedLevel1_7 == true) 
		{
			SceneManager.LoadScene (sceneBuildIndex:19);
		}

		if (LevelType == 16 && Controls.completedLevel1_8 == true) 
		{
			SceneManager.LoadScene (sceneBuildIndex:20);
		}

		if (LevelType == 17 && Controls.completedLevel1_9 == true) 
		{
			SceneManager.LoadScene (sceneBuildIndex:21);
		}

		if (LevelType == 18 && Controls.completedLevel1_10 == true) 
		{
			SceneManager.LoadScene (sceneBuildIndex:22);
		}

		if (LevelType == 19 && Controls.completedLevel2_1 == true) 
		{
			SceneManager.LoadScene (sceneBuildIndex:23);
		}

		if (LevelType == 20 && Controls.completedLevel2_2 == true) 
		{
			SceneManager.LoadScene (sceneBuildIndex:24);
		}

		if (LevelType == 21 && Controls.completedLevel2_3 == true) 
		{
			SceneManager.LoadScene (sceneBuildIndex:25);
		}
	}
}
