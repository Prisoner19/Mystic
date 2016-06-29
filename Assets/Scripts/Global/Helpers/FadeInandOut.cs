using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
	private float alphaTextColor;
	private float timerForText;

	void Start () 
	{
		SetBlackScreen();
		//If need to add Text to Canvas
		if(Application.loadedLevelName == "Title Scene" /*|| more scenes with text*/)
		{
			CreateText();
		}

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
			timerForText -= Time.deltaTime;
			if(timerForText < 0)
			{
				textInCanvas.GetComponent<Text>().color = new Color (1, 1, 1, alphaTextColor);
				alphaTextColor -= 0.45f * Time.deltaTime;
				if(alphaTextColor < 0)
				{
					SceneManager.LoadSceneAsync("Graveyard");
				}
			}
		}
	}

	private void FadeOut()
	{
		gameObject.GetComponent<Renderer> ().material.color = new Color (1, 1, 1, changingAlpha);
		changingAlpha -= 0.45f * Time.deltaTime;
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

	private void SetBlackScreen()
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
		alphaTextColor = 1;
		timerForText = 2;
		if(shouldFadeIn)
		{
			changingAlpha = 0;
		}
		if (shouldFadeOut) 
		{
			changingAlpha = 1;
		}
	}
}
