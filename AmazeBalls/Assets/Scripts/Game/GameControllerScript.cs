using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameControllerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	public void pauseClicked() {
		// TODO: Add Paused Panel

		SceneManager.LoadScene ("HomeScene");
	}
}
