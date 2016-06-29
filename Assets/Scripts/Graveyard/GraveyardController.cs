using UnityEngine;
using System.Collections;

public class GraveyardController : MonoBehaviour 
{
	private GameObject blackScreen;
	public GameObject player;

	void Awake()
	{
		blackScreen = GameObject.Find ("BlackScreen");
		blackScreen.GetComponent<FadeInandOut>().fadeOut = true;
		blackScreen.GetComponent<FadeInandOut>().shouldFadeOut= true;
	}
	void Start () 
	{
		
	}

	void Update () 
	{
		if(blackScreen.GetComponent<FadeInandOut>().changingAlpha < 0)
		{
			player.SetActive (true);
		}
	}
}
