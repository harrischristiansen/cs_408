using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameControllerScript : MonoBehaviour {

	public GameObject PauseButton;
	public GameObject InGameMenu;

	// Use this for initialization
	void Start () {
		InGameMenu.SetActive(false);
	}
	
	public void pauseClicked() {
		PauseButton.SetActive(false);
		InGameMenu.SetActive(true);
	}

	public void restartClicked() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	public void homeClicked() {
		SceneManager.LoadScene ("HomeScene");
	}
}
