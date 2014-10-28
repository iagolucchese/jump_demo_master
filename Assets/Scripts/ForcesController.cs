using UnityEngine;
using System.Collections;

public class ForcesController : MonoBehaviour {

	public ShakeCamera cameraToShake;
	private HealthAndScore healthAndScore;

	public float speedLimit = 15f;
	public float fractionOfSpeedOnCollision = 3f;

	public void SlowForce() {
		rigidbody2D.velocity -= rigidbody2D.velocity/fractionOfSpeedOnCollision; //cuts current speed
		cameraToShake.StartShake();

		healthAndScore.HitObstacle();
	}

	public void AddForce(Vector2 force) {
		rigidbody2D.AddForce(force);

		if (rigidbody2D.velocity.y >= speedLimit)
			rigidbody2D.velocity = new Vector2(0,speedLimit);

		healthAndScore.HitPowerup();
	}

	// Use this for initialization
	void Start () {
		healthAndScore = gameObject.GetComponent<HealthAndScore>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
