using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour {

	public void StartGame()
	{
		SceneManager.LoadScene (sceneBuildIndex:1);
	}
}
