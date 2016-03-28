/*
-- A-Maze-Balls: Purdue CS 408
-- https://github.com/EvanDWalsh/CS-408
-- Spring 2016
*/

using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class BombController : MonoBehaviour {

    private Animator anim;
  
    //Explode and end game
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            anim = GetComponent<Animator>();
            anim.SetTrigger("Explode");
			if(GameControllerScript.debugEnabled) {
				Debug.Log("Bomb Hit!");
			}
			GameControllerScript.GameController.pauseClicked();
            Destroy(col.gameObject);
        }
    }
}
