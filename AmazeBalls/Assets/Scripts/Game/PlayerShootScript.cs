/*
-- A-Maze-Balls: Purdue CS 408
-- https://github.com/EvanDWalsh/CS-408
-- Spring 2016
*/

using UnityEngine;
using System.Collections;

public class PlayerShootScript : MonoBehaviour {
	
	public bool consumeOnUse;

	void OnTriggerEnter2D(Collider2D col) {
		if(col.gameObject.tag == "Player") {
			if(GameControllerScript.debugEnabled) {
				Debug.Log("Enable Player Shoot");
			}

			// Freeze Player
			col.gameObject.GetComponent<PlayerController>().movementEnabled = false;
			col.gameObject.GetComponent<PlayerController>().playerShootEnable();

			// Place at center of self
			col.gameObject.transform.position = gameObject.transform.position;

			// Show Aiming UI
			GameControllerScript.FireMenu.SetActive(true);
		}
	}

	void OnTriggerExit2D(Collider2D col) {
		GameControllerScript.FireMenu.SetActive(false);
		if(consumeOnUse) {
			Destroy(gameObject);
		}
	}
}
