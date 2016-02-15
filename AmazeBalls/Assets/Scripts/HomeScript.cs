using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class HomeScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public void playClicked() {
		SceneManager.LoadScene (SceneManager.GetSceneByName("LevelsScene").buildIndex);
	}

	public void createClicked() {
		SceneManager.LoadScene (SceneManager.GetSceneByName("CreateScene").buildIndex);
	}

	public void scoresClicked() {
		SceneManager.LoadScene (SceneManager.GetSceneByName("HighScoresScene").buildIndex);
	}
	
	public void logoutClicked() {
		// TODO: Perform Logout Action

		SceneManager.LoadScene (SceneManager.GetSceneByName("LoginScene").buildIndex);
	}
}
