using UnityEngine;
using System.Collections;

public class PaintTrail : MonoBehaviour {

	private float destroyPaintTimer = 5.0f;
	
	// Update is called once per frame
	void Update () 
	{
		destroyPaintTimer -= Time.deltaTime;
		if (destroyPaintTimer < 0)
		{
			Destroy (gameObject);
		}
	}
}
