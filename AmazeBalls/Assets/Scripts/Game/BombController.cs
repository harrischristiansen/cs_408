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
            Debug.Log("You Lose!");
            GameObject.Find("GameControllerScriptManager").GetComponent<GameControllerScript>().pauseClicked();
            Destroy(col.gameObject);
        }
    }
}
