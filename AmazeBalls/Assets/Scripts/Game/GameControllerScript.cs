/*
-- A-Maze-Balls: Purdue CS 408
-- https://github.com/EvanDWalsh/CS-408
-- Spring 2016
*/

using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameControllerScript : MonoBehaviour {
	public static bool debugEnabled = false;

	public static GameControllerScript GameController;
	public static GameObject PauseButton;
	public static GameObject InGameMenu;
	public static GameObject FireMenu;

	// Use this for initialization
	void Start () {
		GameController = gameObject.GetComponent<GameControllerScript>();
		PauseButton = GameObject.Find("PauseButton");
		InGameMenu = GameObject.Find("InGameMenu");
		FireMenu = GameObject.Find("FireMenu");
		InGameMenu.SetActive(false);
		FireMenu.SetActive(false);
	}
	
	public void pauseClicked() {
		if(!InGameMenu.activeSelf) {
			InGameMenu.SetActive(true);
		} else {
			InGameMenu.SetActive(false);
		}

	}

	public void restartClicked() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	public void homeClicked() {
		SceneManager.LoadScene ("HomeScene");
	}
}
