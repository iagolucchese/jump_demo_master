using UnityEngine;
using System.Collections;

public class ForcesController : MonoBehaviour {

	public ShakeCamera cameraToShake;

	public void SlowForce() {
		rigidbody2D.velocity -= rigidbody2D.velocity/3; //cuts current speed
		//rigidbody2D.velocity -= new Vector2(0f,1f);

		cameraToShake.StartShake();
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
