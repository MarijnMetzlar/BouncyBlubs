using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PaintBar : MonoBehaviour {

	public Image Bar;
	public float maxAmountOfPaint = 300;

	// Use this for initialization
	void Start () 
	{
		InvokeRepeating ("PaintAmount", 0f, 0.01f);
	}

	void PaintAmount()
	{
		float calc_paint = Player.amountOfPaint / maxAmountOfPaint;
		SetPaint (calc_paint);
	}

	void SetPaint(float myPaint)
	{
		//set color of the bar blue
		if (Player.blubColor == 1) 
		{
			Bar.color = new Color (0.0f, 1.0f, 1.0f, 1.0f);
		}

		//set color of the bar red
		if (Player.blubColor == 2) 
		{
			Bar.color = new Color (1.0f, 0.0f, 0.0f, 1.0f);
		}

		//set color of the bar yellow
		if (Player.blubColor == 3) 
		{
			Bar.color = Color.yellow;
		}

		//set color of the bar green
		if (Player.blubColor == 4) 
		{
			Bar.color = Color.green;
		}

		Bar.fillAmount = myPaint;
	}
}
