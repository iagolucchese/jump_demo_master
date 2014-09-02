using UnityEngine;
using System.Collections;

// When this object is hit, it adds a force to the player (an upward force by default)
public class AddForceOnHit : MonoBehaviour {

	public Vector2 force = new Vector2(0, 100);
	
	void OnTriggerEnter2D(Collider2D other) {
		// Ignore anything but the player
		if (other.tag != "Player") {
			return;
		}

		other.rigidbody2D.AddForce(force);
	}
}
