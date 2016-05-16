using UnityEngine;
using System.Collections;

public class SpinningObject : MonoBehaviour {

	public float rotationSpeed = 60.0f;

	// Update is called once per frame
	void Update () 
	{
		transform.Rotate (Vector3.forward * Time.deltaTime * rotationSpeed);
	}
}
