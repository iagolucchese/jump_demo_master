using UnityEngine;
using System.Collections;

public class SinShake : MonoBehaviour {

	public float shakeStrength = 1f;
	public float lengthOfShake = 4f;
	public int repetitions = 2;

	float curStrength;
	float timeElapsed;

	// Use this for initialization
	void Start () {
		StartShake();
	}
	
	// Update is called once per frame
	void Update () {
		timeElapsed += Time.deltaTime;

		float curStrength = Mathf.Lerp(shakeStrength, 0, timeElapsed / lengthOfShake);

		float degrees = Mathf.Lerp(0, 360 * repetitions, timeElapsed/lengthOfShake);
		float delta = Mathf.Sin(Mathf.Deg2Rad * degrees);

		Vector2 newPos = transform.parent.position;
		newPos.x += delta * curStrength;
		transform.position = newPos;
	}

	public void StartShake() {
		timeElapsed = 0;
	}
}
