using UnityEngine;
using System.Collections;

// Shake this object horizontally
// Assumes this object is a camera
public class ShakeCamera : MonoBehaviour {
	
	// How strong should the shake start?
	public float shakeStrength = 0.5f;
	// How many seconds should the shake last?
	public float length = 2f;
	
	// What's the current strength of the shake?
	float curStrength = 0f;
	// How much time has elapsed since we started shaking?
	float timeElapsed = 0f;
	
	// Use this for initialization
	void Start () {
		// Make sure that it doesn't shake at the beginning
		timeElapsed = length + 1;
	}
	
	// Start shaking
	public void StartShake() {
		// Reset the elapsed time
		timeElapsed = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		// Update the elapsed time
		timeElapsed += Time.deltaTime;
		
		// If we've gone past the end of the shaking time, we're done
		if (timeElapsed > length) {
			// When not shaking, zero out the x position
			Vector3 basePos = transform.position;
			basePos.x = 0;
			transform.position = basePos;
			
			Vector3 baseRot = transform.localEulerAngles;
			baseRot.z = 0;
			transform.localEulerAngles = baseRot;
			return;
		}
		
		// The current strength starts at the max and goes down to zero linearly over 'length' seconds
		curStrength = Mathf.Lerp(shakeStrength, 0, timeElapsed/length);
		
		// Randomly modify the x position of the image randomly based on the current
		//  shake strength
		Vector3 pos = transform.position;
		pos.x = Random.Range(-curStrength, curStrength);
		pos.z = -10;
		transform.position = pos;
		
		Vector3 rot = transform.localEulerAngles;
		rot.z = Random.Range(-curStrength*50, curStrength*50);
		transform.localEulerAngles = rot;
	}
}