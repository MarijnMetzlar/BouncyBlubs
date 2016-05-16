using UnityEngine;
using System.Collections;

public class Pointer : MonoBehaviour {

	public static Vector3 slingPosition;
	public static Vector3 playerPosition;
	public static Vector3 pointerPosition;

	private GameObject player;
	private GameObject sling;

	void Start ()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
		sling = GameObject.FindGameObjectWithTag ("Sling");
	}

	// Update is called once per frame
	void Update () 
	{
		slingPosition = sling.GetComponent<Transform> ().position;
		playerPosition = player.GetComponent<Transform> ().position;
		pointerPosition = (playerPosition - slingPosition) + playerPosition;
		transform.position = pointerPosition;
	}
}
