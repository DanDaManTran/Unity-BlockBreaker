using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	public static bool autoPlay = false;
	
	
	public void LoadLevel (string name){
		Brick.breakableCount = 0;
		Application.LoadLevel(name);
	}
	
	public void EasyGame (string name) {
		autoPlay = true;
		Application.LoadLevel(name);
	}
	
	public void LoadNextLevel () {
		Brick.breakableCount = 0;
		Application.LoadLevel(Application.loadedLevel + 1);
	}
	
	public void BrickDestoryed () {
		if(Brick.breakableCount <= 0)
		{
			LoadNextLevel();
		}
	}
}
