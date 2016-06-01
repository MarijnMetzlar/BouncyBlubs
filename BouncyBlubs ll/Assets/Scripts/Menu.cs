using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	public Canvas worldScreen;
	public Canvas wheelScreen;

	public GameObject world;
	public GameObject wheelOfFortune;
	private float rotationSpeed;
	private bool spinned = false;

	public void Start()
	{
		worldScreen = worldScreen.GetComponent<Canvas> ();
		wheelScreen = wheelScreen.GetComponent<Canvas> ();
		wheelScreen.enabled = false;
		worldScreen.enabled = true;
	}

	public void WheelOfFortune()
	{
		wheelScreen.enabled = true;
		worldScreen.enabled = false;
		world.SetActive (false);
	}

	public void TheWorld()
	{
		wheelScreen.enabled = false;
		worldScreen.enabled = true;
		world.SetActive (true);
	}

	public void SpinWheel()
	{
		if (spinned == false) {
			spinned = true;
			rotationSpeed = Random.Range (-100.0f, -1000.0f);
			wheelOfFortune.GetComponent<Rigidbody2D> ().AddTorque (rotationSpeed);
		}
	}
}