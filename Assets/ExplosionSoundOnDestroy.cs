using UnityEngine;
using System.Collections;

public class ExplosionSoundOnDestroy : MonoBehaviour {

	public SoundEffectsController soundEffectsController;

	void Start() {
		soundEffectsController = GameObject.FindGameObjectWithTag("SoundFX").GetComponent<SoundEffectsController>();
	}

	void OnDestroy() {
		if(soundEffectsController) soundEffectsController.playRandomExplosion();
	}
}
