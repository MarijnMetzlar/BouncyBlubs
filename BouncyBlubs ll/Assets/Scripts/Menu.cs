using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	public void BackToMain()
	{
		SceneManager.LoadScene (sceneBuildIndex:0);
	}

	public void BackToWorld()
	{
		SceneManager.LoadScene (sceneBuildIndex:1);
	}
}