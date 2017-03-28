using UnityEngine;
using System.Collections;

public class RuchPlatformy : MonoBehaviour {

    public float speed = 10f;   
    	
	void FixedUpdate() {
        float inputspeed = 0f;

        inputspeed = Input.GetAxisRaw("Platforma");

        transform.position += new Vector3(inputspeed * speed, 0f, 0f);
	}

}
