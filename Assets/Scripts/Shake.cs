using UnityEngine;
using System.Collections;

public class Shake : MonoBehaviour {

	public float rangeOfShake = 1f;
	public float lengthOfShake = 4f;

	float curStrength;
	float ageOfShake;

	// Use this for initialization
	void Start () {
		StartShake();
	}
	
	// Update is called once per frame
	void Update () {
		ageOfShake += Time.deltaTime;

		float curStrength = Mathf.SmoothStep(rangeOfShake, 0, ageOfShake / lengthOfShake);

		Vector2 newPos = transform.parent.position;
		newPos.x = newPos.x + Random.Range(-curStrength,curStrength);
		transform.position = newPos;
	}

	void StartShake() {
		ageOfShake = 0;
	}
}
