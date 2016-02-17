using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float speed = 25;

	// Velocity Tracking - For Elastic Collisions
	private Vector2 velocity;
	private Vector2 lastPos;

	private Rigidbody2D playerRigidbody;

	void Start() {
		playerRigidbody = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate() {
		// Velocity Tracking - For Elastic Collisions
		Vector3 pos3D = transform.position;
		Vector2 pos2D = new Vector2(pos3D.x, pos3D.y);
		velocity = pos2D - lastPos;
		lastPos = pos2D;

		// Manual Movement
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector2 movement = new Vector2(moveHorizontal, moveVertical);

		playerRigidbody.AddForce(movement * speed);
	}

	void OnCollisionEnter2D(Collision2D col) {
		if(col.gameObject.tag == "Wall") {
			Vector3 N = col.contacts[0].normal;
			Vector3 V = velocity.normalized;
			Vector3 R = Vector3.Reflect(V, N).normalized;
			playerRigidbody.velocity = new Vector2(R.x, R.y) * velocity.magnitude * speed * 2;
		}
	}
}
