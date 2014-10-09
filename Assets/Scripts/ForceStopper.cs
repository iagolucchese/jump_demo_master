using UnityEngine;
using System.Collections;

public class ForceStopper : MonoBehaviour {

	//public Vector2 force = new Vector2(0, 100);

	void OnTriggerEnter2D(Collider2D other) {
		// Ignore anything but the player
		if (other.tag != "Player") {
			return;
		}

		other.GetComponent<ForcesController>().SlowForce();

		particleSystem.Play();
		GetComponentInChildren<ParticleSystem>().Play();
	}
}
