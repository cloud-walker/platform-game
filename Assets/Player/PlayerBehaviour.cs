using UnityEngine;
using System.Collections;

public class PlayerBehaviour : MonoBehaviour {
	Rigidbody2D rb;
	float moveForce = 3f;
	float jumpForce = 500f;
	bool isJumping = false;

	void Start() {
		rb = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate() {
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");

		if (h > 0) {
			rb.velocity = new Vector2(moveForce, rb.velocity.y);
		} else if (h < 0) {
			rb.velocity = new Vector2(-moveForce, rb.velocity.y);
		} else {
			rb.velocity = new Vector2(0, rb.velocity.y);
		}

		if (v > 0 && !isJumping) {
			rb.AddForce(new Vector2(0f, jumpForce));
			isJumping = true;
		}

		if (v == 0) {
			isJumping = false;
		}
	}
}
