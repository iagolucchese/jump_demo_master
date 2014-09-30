using UnityEngine;
using System.Collections;

public class RotateOnCollision : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Obstacle"){
			GetComponentInChildren<SinRotation>().StartRotate();
		}
	}
}
