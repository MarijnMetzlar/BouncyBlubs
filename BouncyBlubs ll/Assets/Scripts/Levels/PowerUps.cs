using UnityEngine;
using System.Collections;

public class PowerUps : MonoBehaviour {

	public int powerUpType;
	public static float speedPowerUp = 1.0f;
	public static int speedPowerUpShots = 3;
	public static bool gotSpeed = false;

	public GameObject player;
	public static int noBouncePowerUpShots = 3;
	public static bool gotNoBounce = false;

	public static int ghostPowerUpShots = 2;
	public static bool gotGhost = false;

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player") 
		{
			//speedPowerUp
			if (powerUpType == 0) 
			{
				gotSpeed = true;
				speedPowerUp = 2.0f;
				Destroy (gameObject);
			}

			//noBouncePowerUp
			if (powerUpType == 1) 
			{
				gotNoBounce = true;
				Destroy (gameObject);
			}

			//ghostPowerUp
			if (powerUpType == 2) 
			{
				gotGhost = true;
				Color oldColor = player.GetComponent<SpriteRenderer> ().color;
				player.GetComponent<SpriteRenderer> ().color = new Color (oldColor.r, oldColor.g, oldColor.b, 0.6f);
				Destroy (gameObject);
			}
		}
	}
}
