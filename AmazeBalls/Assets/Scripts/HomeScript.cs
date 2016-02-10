using UnityEngine;
using System.Collections;

public class HomeScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public void playClicked() {
		Application.LoadLevel("LevelsScene");
	}

	public void createClicked() {
		Application.LoadLevel("CreateScene");
	}

	public void scoresClicked() {
		Application.LoadLevel("HighScoresScene");
	}
	
	public void logoutClicked() {
		// TODO: Perform Logout Action

		Application.LoadLevel("LoginScene");
	}
}
