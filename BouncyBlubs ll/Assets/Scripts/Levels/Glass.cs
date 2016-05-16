using UnityEngine;
using System.Collections;

public class Glass : MonoBehaviour {

	private bool destroyGlass = false;
	private float destroyGlassTimer = 0.1f;

	void Update()
	{
		if (destroyGlass == true) {
			destroyGlassTimer -= Time.deltaTime;
			if (destroyGlassTimer < 0) {
				Destroy (gameObject);
			}
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player") 
		{
			Debug.Log (other.gameObject.GetComponent<Rigidbody2D> ().velocity.magnitude);

			if (other.gameObject.GetComponent<Rigidbody2D> ().velocity.magnitude >= 10.0f) 
			{
				destroyGlass = true;
			}
		}
	}
}
