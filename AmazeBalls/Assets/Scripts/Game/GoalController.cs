using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GoalController : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D col) {
		if(col.gameObject.tag == "Player") {
			// TODO: Add Player Won Panel

			Debug.Log("Player Won!");
			SceneManager.LoadScene("HomeScene");
		}
	}
}
