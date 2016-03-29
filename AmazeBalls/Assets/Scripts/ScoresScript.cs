/*
-- A-Maze-Balls: Purdue CS 408
-- https://github.com/EvanDWalsh/CS-408
-- Spring 2016
*/

using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ScoresScript : MonoBehaviour {

	public void backClicked() {
		SceneManager.LoadScene("HomeScene");
	}

	public void resetClicked() {
		LevelSelectionScript.resetUnlocked();
		SceneManager.LoadScene("HomeScene");
	}
}
