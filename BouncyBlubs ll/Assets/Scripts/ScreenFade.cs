using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScreenFade : MonoBehaviour {
	
	public Canvas UI_Bar;
	public Canvas UI_inGameScore;

	private float fadeInAlpha = 0.0125f;
	private float fadeOutAlpha = 0.0125f;
	public bool fadeOutIsOver = false;
	public static bool fadeInIsOver = false;

	// Use this for initialization
	void Start () 
	{
		UI_Bar.GetComponent<Canvas> ().enabled = false;
		UI_inGameScore.GetComponent<Canvas> ().enabled = false;
		fadeOutIsOver = false;
		fadeInIsOver = false;
		gameObject.GetComponent<SpriteRenderer> ().material.color = new Color(1, 1, 1, 1);
	}

	void Update ()
	{
		if (fadeOutIsOver == false) {
			FadeOut ();
		}
	}

	//for fading in, so if you complete level (opkomen van screen)
	public void FadeIn ()
	{
		Color _color = gameObject.GetComponent<SpriteRenderer>().material.color;
		_color.a += fadeInAlpha;
		gameObject.GetComponent<SpriteRenderer>().material.color = _color;

		//fade animation
		gameObject.GetComponent<Animator>().SetBool("FadeIn", true);
		gameObject.GetComponent<Animator>().SetBool("FadeOut", false);

		if (_color.a >= 1.0f) 
		{
			fadeInIsOver = true;
		}
	}

	//for fading out, so if you start a scene (verdwijnen)
	public void FadeOut ()
	{
		Color color = gameObject.GetComponent<SpriteRenderer>().material.color;
		color.a -= fadeOutAlpha;
		gameObject.GetComponent<SpriteRenderer>().material.color = color;

		//fade animation
		gameObject.GetComponent<Animator>().SetBool("FadeIn", false);
		gameObject.GetComponent<Animator>().SetBool("FadeOut", true);

		if (color.a <= 0.0f) 
		{
			fadeOutIsOver = true;
			UI_Bar.GetComponent<Canvas> ().enabled = true;
			UI_inGameScore.GetComponent<Canvas> ().enabled = true;
		}
	}
}
