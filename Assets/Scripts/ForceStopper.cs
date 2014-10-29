using UnityEngine;
using System.Collections;

public class ForceStopper : MonoBehaviour {

	public SoundEffectsController soundEffectsController;

	void Start() {
		soundEffectsController = GameObject.FindGameObjectWithTag("SoundFX").GetComponent<SoundEffectsController>();
	}

	void OnTriggerEnter2D(Collider2D other) {
		// Ignore anything but the player
		if (other.tag != "Player") {
			return;
		}
		other.GetComponent<ForcesController>().SlowForce();
		foreach (ParticleSystem ps in GetComponentsInChildren<ParticleSystem>()) {
			ps.Play();
		}

		soundEffectsController.playRandomExplosion();
	}
}
