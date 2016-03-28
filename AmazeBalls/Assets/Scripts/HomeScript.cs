/*
-- A-Maze-Balls: Purdue CS 408
-- https://github.com/EvanDWalsh/CS-408
-- Spring 2016
*/

using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class HomeScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public void playClicked() {
		SceneManager.LoadScene("LevelsScene");
	}

	public void createClicked() {
		SceneManager.LoadScene("CreateScene");
	}

	public void scoresClicked() {
		SceneManager.LoadScene("HighScoresScene");
	}
	
	public void logoutClicked() {
		// TODO: Perform Logout Action

		SceneManager.LoadScene("LoginScene");
	}
}
