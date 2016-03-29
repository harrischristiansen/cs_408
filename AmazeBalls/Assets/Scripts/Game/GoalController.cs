/*
-- A-Maze-Balls: Purdue CS 408
-- https://github.com/EvanDWalsh/CS-408
-- Spring 2016
*/

using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GoalController : MonoBehaviour {
	void OnTriggerEnter2D(Collider2D col) {
		if(col.gameObject.tag == "Player") {
			LevelSelectionScript.unlockLevel(GameControllerScript.currentLevel);
			if(GameControllerScript.debugEnabled) {
				Debug.Log("Player Won! Unlocked: "+GameControllerScript.currentLevel);
			}

			PlayerController.didWin = true;
			PlayerController.resultText = "You Won!";
			GameControllerScript.GameController.pauseClicked();
			col.gameObject.GetComponent<PlayerController>().movementEnabled = false;
			Destroy(gameObject);
		}
	}
}
