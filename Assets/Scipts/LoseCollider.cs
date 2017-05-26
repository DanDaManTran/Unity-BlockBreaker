using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {
	
	private LevelManager levelManger; 
	// Use this for initialization
	void OnTriggerEnter2D (Collider2D trigger) {
		levelManger = GameObject.FindObjectOfType<LevelManager>();
		levelManger.LoadLevel("Lose");
	}
}
