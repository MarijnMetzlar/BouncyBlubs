using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ItemScreen : MonoBehaviour {

	public int itemNr;
	public GameObject hat;
	public Sprite none;
	public Sprite devilItem;
	public Sprite fezItem;
	public Sprite haloItem;
	public Sprite tophatItem;

	public void None()
	{
		hat.GetComponent<Image> ().sprite = none;
		itemNr = 0;
	}

	public void DevilHat()
	{
		hat.GetComponent<RectTransform> ().anchoredPosition = new Vector2 (0.3f, 28.6f);
		hat.GetComponent<RectTransform> ().sizeDelta = new Vector2 (186.2f, 108.6f);
		hat.GetComponent<Image> ().sprite = devilItem;
		itemNr = 1;
	}

	public void FezHat()
	{
		hat.GetComponent<RectTransform> ().anchoredPosition = new Vector2 (0.7f, 29.9f);
		hat.GetComponent<RectTransform> ().sizeDelta = new Vector2 (186.2f, 108.6f);
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

}
