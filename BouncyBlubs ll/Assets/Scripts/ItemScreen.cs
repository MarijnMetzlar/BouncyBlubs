using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ItemScreen : MonoBehaviour {

	public static int itemNr;
	public GameObject hat;
	public Sprite none;
	public Sprite devilItem;
	public Sprite fezItem;
	public Sprite haloItem;
	public Sprite tophatItem;
	public Sprite cakeHatItem;
	public Sprite diamondCrownItem;
	public Sprite goldenCrownItem;
	public Sprite monocleItem;
	public Sprite pirateHatItem;
	public Sprite poopooHatItem;
	public Sprite silverCrownItem;
	public Sprite wizardHatItem;

	public void None()
	{
		hat.GetComponent<Image> ().sprite = none;
		itemNr = 0;
	}

	public void DevilHat()
	{
		hat.GetComponent<RectTransform> ().anchoredPosition = new Vector2 (-0.1f, 28.6f);
		hat.GetComponent<RectTransform> ().sizeDelta = new Vector2 (163.3f, 113.4f);
		hat.GetComponent<RectTransform> ().localScale = new Vector3 (0.5233377f, 0.392409f, 0.4046655f);
		hat.GetComponent<Image> ().sprite = devilItem;
		itemNr = 1;
	}

	public void FezHat()
	{
		hat.GetComponent<RectTransform> ().anchoredPosition = new Vector2 (0.2f, 29.2f);
		hat.GetComponent<RectTransform> ().sizeDelta = new Vector2 (80.5f, 95.4f);
		hat.GetComponent<RectTransform> ().localScale = new Vector3 (0.5233377f, 0.392409f, 0.4046655f);
		hat.GetComponent<Image> ().sprite = fezItem;
		itemNr = 2;
	}

	public void HaloHat()
	{
		hat.GetComponent<RectTransform> ().anchoredPosition = new Vector2 (0.7f, 25.4f);
		hat.GetComponent<RectTransform> ().sizeDelta = new Vector2 (186.2f, 88.5f);
		hat.GetComponent<Image> ().sprite = haloItem;
		itemNr = 3;
	}

	public void TopHat()
	{
		hat.GetComponent<RectTransform> ().anchoredPosition = new Vector2 (-5.8f, 31.0f);
		hat.GetComponent<RectTransform> ().sizeDelta = new Vector2 (160.0f, 97.5f);
		hat.GetComponent<Image> ().sprite = tophatItem;
		itemNr = 4;
	}

	public void CakeHat()
	{
		hat.GetComponent<RectTransform> ().anchoredPosition = new Vector2 (1.0f, 35.0f);
		hat.GetComponent<RectTransform> ().sizeDelta = new Vector2 (189.3f, 140.7f);
		hat.GetComponent<Image> ().sprite = cakeHatItem;
		itemNr = 5;
	}

	public void DiamondCrownHat()
	{
		hat.GetComponent<RectTransform> ().anchoredPosition = new Vector2 (-0.3f, 32.0f);
		hat.GetComponent<RectTransform> ().sizeDelta = new Vector2 (189.4f, 113.4f);
		hat.GetComponent<RectTransform> ().localScale = new Vector3 (0.5233377f, 0.392409f, 0.4046655f);
		hat.GetComponent<Image> ().sprite = diamondCrownItem;
		itemNr = 6;
	}

	public void GoldenCrownHat()
	{
		hat.GetComponent<RectTransform> ().anchoredPosition = new Vector2 (0.8f, 30.0f);
		hat.GetComponent<RectTransform> ().sizeDelta = new Vector2 (189.4f, 113.4f);
		hat.GetComponent<RectTransform> ().localScale = new Vector3 (0.5233377f, 0.392409f, 0.4046655f);
		hat.GetComponent<Image> ().sprite = goldenCrownItem;
		itemNr = 7;
	}

	public void MonocleHat()
	{
		hat.GetComponent<RectTransform> ().anchoredPosition = new Vector2 (-0.3f, 7.1f);
		hat.GetComponent<RectTransform> ().sizeDelta = new Vector2 (189.3f, 140.7f);
		hat.GetComponent<RectTransform> ().localScale = new Vector3 (0.5233377f, 0.392409f, 0.4046655f);
		hat.GetComponent<Image> ().sprite = monocleItem;
		itemNr = 8;
	}

	public void PirateHat()
	{
		hat.GetComponent<RectTransform> ().anchoredPosition = new Vector2 (0.8f, 28.4f);
		hat.GetComponent<RectTransform> ().sizeDelta = new Vector2 (188.0f, 147.9f);
		hat.GetComponent<RectTransform> ().localScale = new Vector3 (0.5233377f, 0.392409f, 0.4046655f);
		hat.GetComponent<Image> ().sprite = pirateHatItem;
		itemNr = 9;
	}

	public void PoopooHat()
	{
		hat.GetComponent<RectTransform> ().anchoredPosition = new Vector2 (-0.3f, 30.3f);
		hat.GetComponent<RectTransform> ().sizeDelta = new Vector2 (189.3f, 140.7f);
		hat.GetComponent<Image> ().sprite = poopooHatItem;
		itemNr = 10;
	}

	public void SilverCrownHat()
	{
		hat.GetComponent<RectTransform> ().anchoredPosition = new Vector2 (0.8f, 32.0f);
		hat.GetComponent<RectTransform> ().sizeDelta = new Vector2 (189.4f, 113.4f);
		hat.GetComponent<RectTransform> ().localScale = new Vector3 (0.5233377f, 0.392409f, 0.4046655f);
		hat.GetComponent<Image> ().sprite = silverCrownItem;
		itemNr = 11;
	}

	public void WizardHat()
	{
		hat.GetComponent<RectTransform> ().anchoredPosition = new Vector2 (0.7f, 31.4f);
		hat.GetComponent<RectTransform> ().sizeDelta = new Vector2 (189.3f, 140.7f);
		hat.GetComponent<Image> ().sprite = wizardHatItem;
		itemNr = 12;
	}

}
