using UnityEngine;
using System.Collections;


public class RuchPlatformy : MonoBehaviour {

    public float speed = 10f;   
	public float maxSpeed;
	public float acceleration;

	float move = 0f;

	void FixedUpdate() {
		if (Input.GetKeyDown ("a") || Input.GetKeyDown ("d")) {
			move = 0;
		}

		if (Input.GetKey ("a")) {
			move -= acceleration;
			if (move < -maxSpeed) {
				move = -maxSpeed;
			}
		} 
		if (Input.GetKey ("d")) {
			move += acceleration;
			if (move > maxSpeed) {
				move = maxSpeed;
			}
		}

		if (Input.GetKeyUp ("a") || Input.GetKeyUp ("d")) {
			move = 0;
		}

		transform.position += new Vector3(move, 0f, 0f);
	}
}
