/*
-- A-Maze-Balls: Purdue CS 408
-- https://github.com/EvanDWalsh/CS-408
-- Spring 2016
*/

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelSelectionScript : MonoBehaviour {

	public GameObject GridOfLevels;
	public GameObject LevelPrefab;

	// Use this for initialization
	void Start () {
		// TODO: Load Levels
		int[] levels = new int[7] {1, 2, 3, 4, 5, 6, 7};
		foreach (int level in levels) {
			GameObject newLevel = Instantiate (LevelPrefab);
			newLevel.transform.SetParent(GridOfLevels.transform);
			newLevel.GetComponentsInChildren<Text> ()[0].text = "Level "+level;
			newLevel.name = "Level" + level;
			newLevel.GetComponent<Button> ().onClick.AddListener (delegate { // Add On Click Event
				levelClicked(level);
			});
		}
	}
	
	public void backClicked() {
		SceneManager.LoadScene("HomeScene");
	}

	public void levelClicked(int level) {
		// TODO: Load Correct Level

		SceneManager.LoadScene("GameScene");
	}
}
