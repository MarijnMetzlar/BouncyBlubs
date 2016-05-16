using UnityEngine;
using System.Collections;

public class StartLevels : MonoBehaviour {

	public int LevelType;
	public bool completedLevel = false;

	void OnMouseDown()
	{
		if (LevelType == 1) 
		{
			Application.LoadLevel (5);
		}

		if (LevelType == 2 && Controls.completedLevel1 == true) 
		{
			Application.LoadLevel (6);
		}

		if (LevelType == 3 && Controls.completedLevel2 == true) 
		{
			Application.LoadLevel (7);
		}

		if (LevelType == 4 && Controls.completedLevel3 == true) 
		{
			Application.LoadLevel (8);
		}

		if (LevelType == 5 && Controls.completedLevel4 == true) 
		{
			Application.LoadLevel (9);
		}

		if (LevelType == 6 && Controls.completedLevel5 == true) 
		{
			Application.LoadLevel (10);
		}
	}
}
