using UnityEngine;
using System.Collections;

// Spawns a given prefab occasionally at a random x position
public class Spawner2 : MonoBehaviour {

	// The object we want to spawn
	public GameObject obstaclePrefab;
	public GameObject bouncerPrefab;

	// Spawn every 3 seconds
	public float obstacleDelay = 3.5f;
	public float bouncerDelay = 2f;

	// How much time has currently elapsed?
	float time = 0f;

	// Do some error-checking
	void Start() {
		if (obstaclePrefab == null || bouncerPrefab == null) {
			Debug.LogError("Missing a spawn type in either spawner");
			Destroy(this);
		} else {
			// Spawn the first bouncer immediately
			//time = bouncerDelay;
		}
	}

	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;

		// We've completed our delay, so spawn and reset the timer
		if (time >= obstacleDelay) {
			// Subtracting rather than setting to zero keeps us from losing the little bit of time
			//  if the time isn't exactly the delay
			obstacleDelay += 3.5f; //not the best solution

			// Choose a random x (that's close to the center so we don't have to worry about hanging
			//  off the screen
			float posX = Random.Range(-transform.localScale.x/4,-transform.localScale.x/4);

			// Create our new item
			GameObject obstacle = Instantiate(obstaclePrefab) as GameObject;
			// Give it the correct position
			obstacle.transform.position = new Vector3(posX, transform.position.y, transform.position.z);
			// Give it a semi-random downward push
			//ObstaclePrefab.rigidbody2D.AddForce(new Vector2(0, Random.Range (-50, -100)));

			// Now, make it a little harder
			obstacleDelay += Random.Range(0.5f, 1f);
		}

		if (time >= bouncerDelay) {
			// Subtracting rather than setting to zero keeps us from losing the little bit of time
			//  if the time isn't exactly the delay
			bouncerDelay += 2f; //not the best solution
			
			// Choose a random x (that's close to the center so we don't have to worry about hanging
			//  off the screen
			float posX = Random.Range(-2f,2f);
			
			// Create our new item
			GameObject bouncer = Instantiate(bouncerPrefab) as GameObject;
			// Give it the correct position
			bouncer.transform.position = new Vector3(posX, transform.position.y, transform.position.z);
			// Give it a semi-random downward push
			//bouncerPrefab.rigidbody2D.AddForce(new Vector2(0, Random.Range (-50, -100)));
			
			// Now, make it a little harder
			bouncerDelay += Random.Range(0.5f, 1f);
		}
	}
}
