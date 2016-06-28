using UnityEngine;
using System.Collections;

public class GraveyardController : MonoBehaviour 
{
	private GameObject blackScreen;

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
	
	}
}
