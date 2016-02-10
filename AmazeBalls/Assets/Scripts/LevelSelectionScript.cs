using UnityEngine;
using UnityEngine.UI;
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
			newLevel.transform.parent = GridOfLevels.transform;
			newLevel.GetComponentsInChildren<Text> ()[0].text = "Level "+level;
			newLevel.name = "Level" + level;
		}
	}
	
	public void backClicked() {
		Application.LoadLevel("HomeScene");
	}
}
