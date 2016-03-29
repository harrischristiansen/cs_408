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
	public static int currentLevel = 0;

	public static GameControllerScript GameController;
	public GameObject[] Levels;
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

		foreach(GameObject level in Levels) { // Disable All Levels
			level.SetActive(false);
		}
		if(currentLevel >= Levels.Length) { // Invalid currentLevel
			if(debugEnabled) {
				Debug.Log("Level Does Not Exist: "+currentLevel);
			}
			SceneManager.LoadScene("HomeScene");
			return;
		}

		Levels[currentLevel].SetActive(true);
	}
	
	public void pauseClicked() {
		if(!InGameMenu.activeSelf) {
			ScoreField.text = "Score: " + PlayerController.currentBounceCount; // Update Score UI
			ResultField.text = PlayerController.resultText;
			InGameMenu.SetActive(true);
			if(PlayerController.didWin) { // Change Restart button to "Next"
				currentLevel++;
				GameObject.Find("RestartText").GetComponent<Text>().text = "Next";
			}
		} else {
			InGameMenu.SetActive(false);
		}
	}

	public void restartClicked() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	public void homeClicked() {
		SceneManager.LoadScene("HomeScene");
	}
}
