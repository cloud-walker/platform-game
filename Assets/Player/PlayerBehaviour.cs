using UnityEngine;
using System.Collections;

public class PlayerBehaviour : MonoBehaviour {
	Rigidbody2D rb;

	void Start() {
		rb = GetComponent<Rigidbody2D>();
	}

  void FixedUpdate() {
    float x = Input.GetAxis("Horizontal");
    float y = Input.GetAxis("Vertical");

    Vector2 movement = new Vector2(x, y);

    rb.AddForce(movement * 100);
  }
}
