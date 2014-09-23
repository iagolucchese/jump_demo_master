using UnityEngine;
using System.Collections;

public class ShakeOnCollision : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Platform"){
			GetComponentInChildren<SinShake>().StartShake();
		}
	}
}
