using UnityEngine;
using System.Collections;

public class GameControllerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	public void pauseClicked() {
		// TODO: Add Paused Window
		
		Application.LoadLevel("HomeScene");
	}
}
