/*
-- A-Maze-Balls: Purdue CS 408
-- https://github.com/EvanDWalsh/CS-408
-- Spring 2016
*/

using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float manualSpeed = 25;
	public float rotateSpeed = 1.0f;
	public float fireSpeed = 8000;
	public bool movementEnabled = true;

	public static int currentBounceCount = -1; // Score Keepingc
	public static string resultText = "";
	public static bool didWin = false;

	// Velocity Tracking - For Elastic Collisions
	private Vector2 velocity;
	private Vector2 lastPos;
	private float currentRotation;

	private Rigidbody2D playerRigidbody;
	public GameObject directionArrow;

	void Start() {
		playerRigidbody = GetComponent<Rigidbody2D>();
		directionArrow.SetActive(false);

		currentBounceCount = -1; // Starts -1 so first StartShoot does not impact
		resultText = "";
		didWin = false;
	}

	void FixedUpdate() {
		// Velocity Tracking - For Elastic Collisions
		Vector3 pos3D = transform.position;
		Vector2 pos2D = new Vector2(pos3D.x, pos3D.y);
		velocity = pos2D - lastPos;
		lastPos = pos2D;

		if(currentRotation != 0.0f) {
			playerRigidbody.MoveRotation(playerRigidbody.rotation + currentRotation);
		}

		if(movementEnabled) {
			// Manual Movement
			float moveHorizontal = Input.GetAxis("Horizontal");
			float moveVertical = Input.GetAxis("Vertical");

			Vector2 movement = new Vector2(moveHorizontal, moveVertical);

			playerRigidbody.AddForce(movement * manualSpeed);
		} else {
			Vector2 currentVelocity = playerRigidbody.velocity;
			if(currentVelocity.x != 0 || currentVelocity.y != 0) {
				playerRigidbody.velocity = new Vector2(0.0f, 0.0f);
			}
		}
	}

	void OnCollisionEnter2D(Collision2D col) {
		if(col.gameObject.tag == "Wall") { // Collisions with walls
			// "Bounce" Off Wall
			Vector3 N = col.contacts[0].normal;
			Vector3 V = velocity.normalized;
			Vector3 R = Vector3.Reflect(V, N).normalized;
			playerRigidbody.velocity = new Vector2(R.x, R.y) * velocity.magnitude * manualSpeed * 2;

			// Increment Bounce Count
			currentBounceCount++;
		}
	}

	public void playerShootEnable() {
		directionArrow.SetActive(true);
		currentRotation = 0.0f;
		playerRigidbody.MoveRotation(0.0f);
		playerRigidbody.inertia = 0.0f;

		// Increment Bounce Count
		currentBounceCount++;
	}

	public void playerShootRotateLeft() {
		if(GameControllerScript.debugEnabled) {
			Debug.Log("Rotate Left!");
		}
		currentRotation = rotateSpeed;
	}

	public void playerShootRotateRight() {
		if(GameControllerScript.debugEnabled) {
			Debug.Log("Rotate Right!");
		}
		currentRotation = -rotateSpeed;
		
	}

	public void playerShootStopRotate() {
		if(GameControllerScript.debugEnabled) {
			Debug.Log("Rotate Stop!");
		}
		currentRotation = 0.0f;
	}

	public void playerShootFirePlayer() {
		if(GameControllerScript.debugEnabled) {
			Debug.Log("Fire!");
		}
		directionArrow.SetActive(false);
		GameControllerScript.GameController.FireMenu.SetActive(false);
		movementEnabled = true;
		playerRigidbody.AddForce(transform.up * fireSpeed);
	}
}
