using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GoalController : MonoBehaviour {
	void OnTriggerEnter2D(Collider2D col) {
		if(col.gameObject.tag == "Player") {
			Debug.Log("Player Won!");
			GameObject.Find("GameControllerScriptManager").GetComponent<GameControllerScript>().pauseClicked();
			col.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0.0f, 0.0f);
			Destroy(gameObject);
		}
	}
}
