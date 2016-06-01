using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour {

	public int LevelType;
	public bool completedLevel = false;

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
	}
}
