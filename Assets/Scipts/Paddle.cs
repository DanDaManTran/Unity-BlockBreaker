using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {
	// Use this for initialization
	private Ball ball;
	void Start () {
		ball = GameObject.FindObjectOfType<Ball>();
	}
	
	// Update is called once per frame
	void Update () {
		if(!LevelManager.autoPlay)
		{
			MoveWithMouse();
		}
		else 
		{
			AutoPlay();
		}
	}
	
	void MoveWithMouse () {
		Vector3 paddlePos = new Vector3(0.5f, this.transform.position.y, 0f);
		float mousePosition = Input.mousePosition.x / Screen.width * 16;	
		paddlePos.x = Mathf.Clamp(mousePosition, 0.5f, 15.5f);;
		this.transform.position = paddlePos;
	}
	
	void AutoPlay () {
		Vector3 paddlePos = new Vector3(0.5f, this.transform.position.y, 0f);
		Vector3 ballPos = ball.transform.position;
		paddlePos.x = Mathf.Clamp(ballPos.x, 0.5f, 15.5f);;
		this.transform.position = paddlePos;
	}
}
