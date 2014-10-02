using UnityEngine;
using System.Collections;

public class SinRotation : MonoBehaviour {

	//public float strength = 1f;
	public float length = 1f;
	public int repetitions = 2;

	float curStrength;
	float timeElapsed = 1;

	// Use this for initialization
	void Start () {
		//StartShake();
	}
	
	// Update is called once per frame
	void Update () {
		if (timeElapsed <= length) {
			timeElapsed += Time.deltaTime;

			//float curStrength = Mathf.Lerp(shakeStrength, 0, timeElapsed / lengthOfShake);

			float degrees = Mathf.SmoothStep(0, 360 * repetitions, timeElapsed/length);
			//float delta = Mathf.Sin(Mathf.Deg2Rad * degrees);

			//newPos.x += delta * curStrength;
			transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, transform.rotation.z + degrees);
		} else {
			//transform.rotation = Quaternion.Euler(Vector3.zero);
		}
	}

	public void StartRotate() {
		if (timeElapsed > length)
			timeElapsed = 0;
	}
}
