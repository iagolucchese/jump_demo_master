using UnityEngine;
using System.Collections;

public class Stretcher : MonoBehaviour {

	public float stretchByXTimes = 1.3f;
	public float duration = 1f;

	float timeElapsed = 1;

	// Update is called once per frame
	void Update () {
		if (timeElapsed <= duration) {
			timeElapsed += Time.deltaTime;

			float stretch = Mathf.Lerp(1,stretchByXTimes,Mathf.Sin(timeElapsed/duration * Mathf.PI));

			transform.localScale = transform.parent.localScale * stretch;
		}
	}

	public void StretchThis() {
		timeElapsed = 0;
		particleSystem.Play();
	}
}
