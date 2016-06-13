﻿using UnityEngine;
using System.Collections;

public class WhiteRedFloor : ColorChip {

	public Sprite blueRedSquare;
	public Sprite yellowRedSquare;
	public Sprite greenRedSquare;
	public Sprite correctRedSquare;

	private AudioSource fillingSounds;
	public AudioClip fillSound;

	void Start()
	{
		fillingSounds = GetComponent<AudioSource> ();
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player") 
		{
			if (Player.blubColor == Player.BLUE) {
				fillingSounds.PlayOneShot (fillSound);
			}
			if (Player.blubColor == Player.RED) {
				fillingSounds.PlayOneShot (fillSound);
			}
			if (Player.blubColor == Player.YELLOW) {
				fillingSounds.PlayOneShot (fillSound);
			}
			if (Player.blubColor == Player.GREEN) {
				fillingSounds.PlayOneShot (fillSound);
			}
		}
	}

	void OnTriggerStay2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player") 
		{
			if (Player.blubColor == Player.BLUE) { //Player with color blue
				gameObject.GetComponent<SpriteRenderer> ().sprite = blueRedSquare;
				IsCorrect = false;
			}

			if (Player.blubColor == Player.RED) { //Player with color red
				gameObject.GetComponent<SpriteRenderer> ().sprite = correctRedSquare;
				IsCorrect = true;
			}

			if (Player.blubColor == Player.YELLOW) { //Player with color yellow
				gameObject.GetComponent<SpriteRenderer> ().sprite = yellowRedSquare;
				IsCorrect = false;
			}

			if (Player.blubColor == Player.GREEN) { //Player with color green
				gameObject.GetComponent<SpriteRenderer> ().sprite = greenRedSquare;
				IsCorrect = false;
			}
		}
	}
}
