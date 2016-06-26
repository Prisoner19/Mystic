using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TitleScreenController : MonoBehaviour 
{

	void Start () 
	{
	
	}
	
	void Update ()
	{
	
	}

	public void StartGame()
	{
		SceneManager.LoadSceneAsync("Desert");
	}
}
