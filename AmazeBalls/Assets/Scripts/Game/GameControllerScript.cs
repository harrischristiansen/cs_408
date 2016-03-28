/*
-- A-Maze-Balls: Purdue CS 408
-- https://github.com/EvanDWalsh/CS-408
-- Spring 2016
*/

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameControllerScript : MonoBehaviour {
	public static bool debugEnabled = false;

	public static GameControllerScript GameController;
	public GameObject PauseButton;
	public GameObject InGameMenu;
	public GameObject FireMenu;
	public Text ScoreField;
	public Text ResultField;

	// Use this for initialization
	void Start () {
		GameController = gameObject.GetComponent<GameControllerScript>();
		InGameMenu.SetActive(false);
		FireMenu.SetActive(false);
	}
	
	public void pauseClicked() {
		if(!InGameMenu.activeSelf) {
			ScoreField.text = "Score: " + PlayerController.currentBounceCount; // Update Score UI
			ResultField.text = PlayerController.resultText;
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
