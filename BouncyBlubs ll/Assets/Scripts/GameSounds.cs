using UnityEngine;
using System.Collections;

public class GameSounds : MonoBehaviour {

	public AudioClip levelSound1;
	public AudioClip levelSound2;
	public AudioClip levelSound3;
	public AudioClip levelSound4;
	public AudioClip levelSound5;
	private AudioSource allLevelSounds;

	private int playSoundLevel;
	// Use this for initialization
	void Start ()
	{
		allLevelSounds = GetComponent<AudioSource> ();

		playSoundLevel = Random.Range (0, 5);
		if (playSoundLevel == 0) 
		{
			allLevelSounds.PlayOneShot (levelSound1);
		}

		if (playSoundLevel == 1) 
		{
			allLevelSounds.PlayOneShot (levelSound2);
		}

		if (playSoundLevel == 2) 
		{
			allLevelSounds.PlayOneShot (levelSound3);
		}

		if (playSoundLevel == 3) 
		{
			allLevelSounds.PlayOneShot (levelSound4);
		}

		if (playSoundLevel == 4) 
		{
			allLevelSounds.PlayOneShot (levelSound5);
		}
	}
}
