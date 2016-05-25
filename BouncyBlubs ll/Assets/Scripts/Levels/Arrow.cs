using UnityEngine;
using System.Collections;

public class Arrow : MonoBehaviour {

	public Sprite arrow1;
	public Sprite arrow2;
	public Sprite arrow3;

	// Update is called once per frame
	void Update () 
	{
		transform.position = GameObject.FindGameObjectWithTag ("Player").transform.position;

		RotateObject ();
		ScaleObject ();
		ArrowSprite ();
	}

	void RotateObject ()
	{
		Vector2 direction = Pointer.pointerPosition - transform.position;
		float angle = Mathf.Atan2 (direction.y, direction.x);
		transform.rotation = Quaternion.Euler (0f, 0f, angle * Mathf.Rad2Deg);
	}

	void ScaleObject ()
	{
		transform.localScale = new Vector3(1f * Sling.playerDistance, 1.5f, 0);

		if (Sling.playerDistance > 2.0f) 
		{
			transform.localScale = new Vector3(2, 1.5f, 0);
		}
	}

	void ArrowSprite ()
	{
		if (Controls.blubSpeed >= 600) {
			gameObject.GetComponent<SpriteRenderer> ().sprite = arrow3;
		} else if (Controls.blubSpeed >= 300 && Controls.blubSpeed <= 600) {
			gameObject.GetComponent<SpriteRenderer> ().sprite = arrow2;
		} else if (Controls.blubSpeed <= 300) {
			gameObject.GetComponent<SpriteRenderer> ().sprite = arrow1;
		}
	}
}
