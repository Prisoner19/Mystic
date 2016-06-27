using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TitleScreenController : MonoBehaviour 
{
	private GameObject blackScreen;
	private GameObject button;

	void Awake()
	{
		blackScreen = GameObject.Find ("BlackScreen");
		button = GameObject.Find ("Canvas/Button");
		blackScreen.GetComponent<FadeInandOut>().fadeIn = true;
	}

	void Start () 
	{
		
	}
	
	void Update ()
	{
	
	}

	public void StartGame()
	{
		button.SetActive (false);
		blackScreen.GetComponent<FadeInandOut>().shouldFadeIn = true;
		//SceneManager.LoadSceneAsync("Desert");
	}
}
