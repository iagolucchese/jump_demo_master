using UnityEngine;
using System.Collections;

public class SinShake : MonoBehaviour {

	//public float strength = 1f;
	public float length = 2f;
	public int repetitions = 2;

	float curStrength;
	float timeElapsed = 1;

	// Use this for initialization
	void Start () {
		//StartShake();
	}
	
	// Update is called once per frame
	void Update () {
		timeElapsed += Time.deltaTime;

		//float curStrength = Mathf.Lerp(shakeStrength, 0, timeElapsed / lengthOfShake);

		float degrees = Mathf.SmoothStep(0, 360 * repetitions, timeElapsed/length);
		//float delta = Mathf.Sin(Mathf.Deg2Rad * degrees);

		//newPos.x += delta * curStrength;
		transform.rotation = Quaternion.Euler(transform.parent.rotation.x,transform.parent.rotation.y,transform.parent.rotation.z + degrees);
	}

	public void StartShake() {
		timeElapsed = 0;
	}
}
