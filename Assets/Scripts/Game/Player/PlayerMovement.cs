using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour 
{
	private float speed;
	private float camHeight;
	private float camWidth;
	private float camSpeed;
	private int screen;
	private Camera cam;
	void Start () 
	{
		screen = 0;
		speed = 10f; //3.5f;
		camSpeed = 30f;
		cam = Camera.main;
		camHeight = cam.orthographicSize;
		camWidth = camHeight * Screen.width / Screen.height;
	}

	void Update () 
	{
		MoveCamera();
		PlayerControl ();
	}
	private void PlayerControl()
	{
		if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
		{
			transform.position += Vector3.left * speed * Time.deltaTime;
		}
		if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
		{
			transform.position += Vector3.right * speed * Time.deltaTime;
		}
	}
	private void MoveCamera()
	{
		if(Application.loadedLevelName == "Graveyard")
		{
			switch(screen) 
			{
			case 0:
				{
					if(transform.position.x > 8.89f)
					{
						cam.transform.position = new Vector3 (17.78f, 0, -10);
						screen = screen + 1;
					}
//					if(transform.position.x > camWidth)
//					{
//						cam.transform.Translate(new Vector3 (camSpeed * Time.deltaTime, 0, 0));
//						if(cam.transform.position.x > camWidth * 2f)
//						{
//							camSpeed = 0;
//							camWidth = camWidth * 3f;
//							screen = 1;
//						}
//					}
				}
				break;
			case 1:
				{
					if(transform.position.x > 26.67f)
					{
						cam.transform.position = new Vector3 (35.56f, 0, -10);
						screen = screen + 1;
					}
					if(transform.position.x < 8.89f)
					{
						cam.transform.position = new Vector3 (0f, 0, -10);
						screen = screen -1;
					}
//					if (transform.position.x > camWidth) 
//					{
//						camSpeed = 30f;
//						cam.transform.Translate(new Vector3 (camSpeed * Time.deltaTime, 0, 0));
//						if(cam.transform.position.x > camWidth)
//						{
//							camSpeed = 0;
//							screen = 2;
//						}
//					}
				}
				break;
				case 2:
				{
					if(transform.position.x < 26.67f)
					{
						cam.transform.position = new Vector3 (17.78f, 0, -10);
						screen = screen - 1;
					}
				}
				break;
			}
		}
	}
}
