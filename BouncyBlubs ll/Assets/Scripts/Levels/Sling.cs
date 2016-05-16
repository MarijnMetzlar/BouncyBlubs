using UnityEngine;
using System.Collections;

public class Sling : MonoBehaviour {

	public static float playerDistance;
	private Vector3 vect;
	private float distance = 2.0f;

	void Update() 
	{
		Vector3 playerPosition = GameObject.FindGameObjectWithTag ("Player").transform.position;
		Vector3 mouseWorldPoint = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		mouseWorldPoint.z = 0.0f;
		gameObject.GetComponent<Transform> ().position = mouseWorldPoint;

		playerDistance = Vector2.Distance (playerPosition, gameObject.transform.position);
		if (playerDistance > distance) 
		{
			vect = playerPosition - gameObject.transform.position;
			vect = vect.normalized;
			vect *= (playerDistance - distance);
			transform.position += vect;
		}
	}
}
