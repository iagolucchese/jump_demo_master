using UnityEngine;
using System.Collections;

// Sets the camera to follow the given target along the y-axis up (but not down)
public class CameraFollow : MonoBehaviour {

	public GameObject target;
	
	// Update is called once per frame
	void Update () {
		if (target == null) {
			return;
		}

		// If the player is higher up than the camera, move the camera up
		if (target.transform.position.y > transform.position.y) {
			Vector3 newPos = transform.position;
			newPos.y = target.transform.position.y;
			transform.position = newPos;
		}
	}
}
