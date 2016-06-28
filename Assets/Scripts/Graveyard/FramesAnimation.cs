using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FramesAnimation : MonoBehaviour 
{
	List<Sprite> spriteList;
	GameObject introAnimated;
	//private int index;
	void Start () 
	{
		introAnimated = GameObject.Find("Intro Animated");
		SetUpSprites ();
	}

	void Update () 
	{
		//introAnimated.GetComponent<SpriteRenderer> ().sprite = spriteList[index];
	}

	private void SetUpSprites()
	{
		spriteList = new List<Sprite> ();
		spriteList.Add(Resources.Load<Sprite>("Sprites/12744619_10153939907103615_5183832140879577278_"));
		spriteList.Add(Resources.Load<Sprite>("Sprites/67082-Im-Watching-You"));
		spriteList.Add(Resources.Load<Sprite>("Smiley-face-text-2g80hyp"));
	}
}
