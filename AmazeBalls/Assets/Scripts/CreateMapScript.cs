using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class CreateMapScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	public void backClicked() {
		SceneManager.LoadScene (SceneManager.GetSceneByName("HomeScene").buildIndex);
	}
}
