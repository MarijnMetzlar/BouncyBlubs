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
			SceneManager.LoadScene (sceneBuildIndex:3);
		}

		if (LevelType == 2 && Controls.completedLevel1 == true) 
		{
			SceneManager.LoadScene (sceneBuildIndex:4);
		}

		if (LevelType == 3 && Controls.completedLevel2 == true) 
		{
			SceneManager.LoadScene (sceneBuildIndex:5);
		}

		if (LevelType == 4 && Controls.completedLevel3 == true) 
		{
			SceneManager.LoadScene (sceneBuildIndex:6);
		}

		if (LevelType == 5 && Controls.completedLevel4 == true) 
		{
			SceneManager.LoadScene (sceneBuildIndex:7);
		}

		if (LevelType == 6 && Controls.completedLevel5 == true) 
		{
			SceneManager.LoadScene (sceneBuildIndex:8);
		}

		if (LevelType == 7 && Controls.completedLevel6 == true) 
		{
			SceneManager.LoadScene (sceneBuildIndex:9);
		}
	}
}
