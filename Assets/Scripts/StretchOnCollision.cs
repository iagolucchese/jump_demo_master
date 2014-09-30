using UnityEngine;
using System.Collections;

public class StretchOnCollision : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Platform") {
			GetComponentInChildren<Stretcher>().StretchThis();
		}
	}
}
