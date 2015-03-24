using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	private int currentLevel;

	void Start() {
		currentLevel = 1;
	}

	public void LoadNextLevel() {
		Application.LoadLevel (Application.loadedLevel + 1);
	}

	public void LoadLevel(string name) {
		Application.LoadLevel (name);
	}
	public void RequestQuit() {
		Application.Quit();
	}
}
