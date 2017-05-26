using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {
	
	public int maxHit;
	public AudioClip crack;
	public static int breakableCount = 0;
	
	private int timesHit;
	private LevelManager levelManager;
	private bool isBreakble;
	// Use this for initialization
	void Start () {
		isBreakble = (this.tag == "Breakable");
		if(isBreakble)
		{
			breakableCount++;
		}
		
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		timesHit = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter2D (Collision2D col){
		timesHit++;
		AudioSource.PlayClipAtPoint (crack, transform.position, (float)0.1f);
		Color temp = GetComponent<SpriteRenderer>().color;
		temp.r = temp.r + 0.2f;
		temp.b = temp.b +0.3f;
		GetComponent<SpriteRenderer>().color = temp;
		
		if(timesHit >= maxHit)
		{
			breakableCount--;
			levelManager.BrickDestoryed();
			Destroy(gameObject);
			
		}
	}
}
