using UnityEngine;
using System.Collections;

public class ExplosionController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.particleSystem.Play();
		Destroy(gameObject,gameObject.particleSystem.duration);
	}
}