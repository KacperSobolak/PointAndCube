using UnityEngine;
using System.Collections;

public class NiszczeniePunktow : MonoBehaviour {

	void Start () {
	
	}
	
	void Update () {
	
	}

    void OnCollisionEnter(Collision kolizja)
    {
        Destroy(gameObject);
    }
}
