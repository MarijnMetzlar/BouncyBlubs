using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class World : MonoBehaviour {

	private float sensitivityX = 1.0f;
	private float sensitivityY = 1.0f;
	public Transform referenceCamera;

	private bool rotationStart = true;
	private bool rotateToWorld1 = false;
	private bool rotateToWorld2 = false;
	private bool rotateToWorld3 = false;

	public Canvas tutorialWorldScreen;
	public Canvas world2Screen;
	public Canvas world3Screen;
	public Text worldText;
	public Button lookAtWorld;

	public GameObject overWorld;

	void Start()
	{
		if (!referenceCamera) 
		{
			if (!Camera.main) 
			{
				Debug.Log ("well shit");
				Destroy (this);
				return;
			}
			referenceCamera = Camera.main.transform;
		}
	}

	void Update()
	{
		//raycast from camera
		Ray ray = Camera.main.ViewportPointToRay (new Vector3(0.5f, 0.5f, 0));
		Debug.DrawRay (ray.origin, ray.direction * 20.0f, Color.cyan);
		RaycastHit hit;

		if(Physics.Raycast(ray, out hit) == true)
		{
			RayHit (hit);
		}

		//rotation of world at first
		if (rotationStart == true) 
		{
			transform.Rotate (new Vector3(1.5f, 1.0f, 0.0f) * 0.25f);
			tutorialWorldScreen.GetComponent<Canvas> ().enabled = false;
			world2Screen.GetComponent<Canvas> ().enabled = false;
			world3Screen.GetComponent<Canvas> ().enabled = false;
		}

		ClickOnWorlds ();
	}

	void OnMouseDrag()
	{
		rotationStart = false;

		float rotationX = Input.GetAxis ("Mouse X") * sensitivityX;
		float rotationY = Input.GetAxis ("Mouse Y") * sensitivityY;

		transform.RotateAroundLocal (referenceCamera.up, -Mathf.Deg2Rad * rotationX);
		transform.RotateAroundLocal (referenceCamera.right, Mathf.Deg2Rad * rotationY);
	}

	private void RayHit(RaycastHit hit)
	{
		switch (hit.transform.gameObject.tag) 
		{
		case "World1":
			tutorialWorldScreen.GetComponent<Canvas> ().enabled = true;
			world2Screen.GetComponent<Canvas> ().enabled = false;
			world3Screen.GetComponent<Canvas> ().enabled = false;
			worldText.text = "World 1";
			break;
		case "World2":
			tutorialWorldScreen.GetComponent<Canvas> ().enabled = false;
			world2Screen.GetComponent<Canvas> ().enabled = true;
			world3Screen.GetComponent<Canvas> ().enabled = false;
			worldText.text = "World 2";
			break;
		case "World3":
			tutorialWorldScreen.GetComponent<Canvas> ().enabled = false;
			world2Screen.GetComponent<Canvas> ().enabled = false;
			world3Screen.GetComponent<Canvas> ().enabled = true;
			worldText.text = "World 3";
			break;
		default:
			tutorialWorldScreen.GetComponent<Canvas> ().enabled = false;
			world2Screen.GetComponent<Canvas> ().enabled = false;
			world3Screen.GetComponent<Canvas> ().enabled = false;
			break;
		}
	}

	void ClickOnWorlds()
	{
		if(Input.GetMouseButtonDown(0))
		{
			RaycastHit hitInfo = new RaycastHit ();
			bool hit = Physics.Raycast (Camera.main.ScreenPointToRay (Input.mousePosition), out hitInfo);
			rotationStart = false;

			if (hit) 
			{
				if (hitInfo.transform.gameObject.tag == "World1") 
				{
					rotateToWorld1 = true;
				}

				if (hitInfo.transform.gameObject.tag == "World2") 
				{
					rotateToWorld2 = true;
				}

				if (hitInfo.transform.gameObject.tag == "World3") 
				{
					rotateToWorld3 = true;
				}
			}
		}

		float speed = 100.0f;
		float step = speed * Time.deltaTime;

		if (rotateToWorld1 == true) 
		{
			gameObject.GetComponent<Transform> ().rotation = Quaternion.RotateTowards (transform.rotation, Quaternion.Euler (10.24224f, 352.8783f, 17.87624f), step);
		}

		if (gameObject.transform.rotation == Quaternion.Euler (10.24224f, 352.8783f, 17.87624f)) 
		{
			rotateToWorld1 = false;
		}

		if (rotateToWorld2 == true) 
		{
			gameObject.GetComponent<Transform> ().rotation = Quaternion.RotateTowards (transform.rotation, Quaternion.Euler (305.5844f, 349.3838f, 13.87725f), step);
		}

		if (gameObject.transform.rotation == Quaternion.Euler (305.5844f, 349.3838f, 13.87725f)) 
		{
			rotateToWorld2 = false;
		}

		if (rotateToWorld3 == true) 
		{
			gameObject.GetComponent<Transform> ().rotation = Quaternion.RotateTowards (transform.rotation, Quaternion.Euler (331.7851f, 183.173f, 118.4165f), step);
		}

		if (gameObject.transform.rotation == Quaternion.Euler (331.7851f, 183.173f, 118.4165f)) 
		{
			rotateToWorld3 = false;
		}
	}

	public void ZoomTutorialWorld()
	{
		Application.LoadLevel (2);
	}

	public void ZoomWorld2()
	{
		Application.LoadLevel (3);
	}

	public void ZoomWorld3()
	{
		Application.LoadLevel (4);
	}
}
