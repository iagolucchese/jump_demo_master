using UnityEngine;
using System.Collections;

public class ForcesController : MonoBehaviour {

	public ShakeCamera cameraToShake;

	public float speedLimit = 15f;
	public float fractionOfSpeedOnCollision = 3f;

	public void SlowForce() {
		rigidbody2D.velocity -= rigidbody2D.velocity/fractionOfSpeedOnCollision; //cuts current speed
		//rigidbody2D.velocity -= new Vector2(0f,1f);

		cameraToShake.StartShake();
	}

	public void AddForce(Vector2 force) {
		rigidbody2D.AddForce(force);

		if (rigidbody2D.velocity.y >= speedLimit)
			rigidbody2D.velocity = new Vector2(0,speedLimit);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
