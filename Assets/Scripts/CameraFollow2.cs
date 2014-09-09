using UnityEngine;
using System.Collections;

public class CameraFollow2 : MonoBehaviour {

	public Camera cam;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (!cam)
			return;

		if (cam.transform.position.y < transform.position.y) {
			cam.transform.position = new Vector3(cam.transform.position.x, transform.position.y, cam.transform.position.z);
		}
	}
}
