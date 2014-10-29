using UnityEngine;
using System.Collections;

public class SoundEffectsController : MonoBehaviour {

	public AudioClip[] listOfExplosionSounds;

	public void playRandomExplosion() {
		gameObject.audio.clip = listOfExplosionSounds[Random.Range(0,listOfExplosionSounds.Length)]; //picks a random sound from the list
		gameObject.audio.Play(); //and plays it
	}
}
