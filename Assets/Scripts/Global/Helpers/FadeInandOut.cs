using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FadeInandOut : MonoBehaviour 
{
	private Sprite blackScreen;
	private GameObject canvas;
	private GameObject createdText;
	private Text textInCanvas;
	[HideInInspector]
	public bool fadeIn;
	[HideInInspector]
	public bool fadeOut;
	[HideInInspector]
	public bool shouldFadeIn;
	[HideInInspector]
	public bool shouldFadeOut;
	[HideInInspector]
	public float changingAlpha;

	void Start () 
	{
		if(fadeIn == true)
		{
			gameObject.GetComponent<SpriteRenderer> ().enabled = false;
		}
		if(fadeOut == true)
		{
			gameObject.GetComponent<SpriteRenderer> ().enabled = true;
		}
		blackScreen= (Resources.Load<Sprite>("Sprites/BlackScreen"));
		gameObject.GetComponent<SpriteRenderer>().sprite = blackScreen;
		changingAlpha = 0;
		//If need to add Text to Canvas
		CreateText();
	}
	
	void Update () 
	{
		if(shouldFadeIn == true)
		{
			FadeIn();
		}
		if(shouldFadeOut == true)
		{
			FadeOut();
		}
	}

	private void FadeIn()
	{
		gameObject.GetComponent<SpriteRenderer> ().enabled = true;
		gameObject.GetComponent<Renderer> ().material.color = new Color (1, 1, 1, changingAlpha);
		changingAlpha += 0.75f * Time.deltaTime;
		// If need to show text
		if(changingAlpha > 1f)
		{
			textInCanvas.text = "CHORIZON PA TODOS";
		}
	}

	private void FadeOut()
	{
		
	}

	private void CreateText()
	{
		canvas = GameObject.Find("Canvas");
		createdText = new GameObject("TextInBlackScreen");
		createdText.transform.SetParent(canvas.transform);
		textInCanvas = createdText.AddComponent<Text>();
		textInCanvas.fontSize = 20;
		textInCanvas.transform.position = new Vector3 (250,250,0);
		Font ArialFont = (Font)Resources.GetBuiltinResource(typeof(Font), "Arial.ttf");
		textInCanvas.font = ArialFont;
	}
}
