using UnityEngine;
using System.Collections;

// Show the height of the target in this GUIText field
[RequireComponent (typeof (GUIText))]
public class ShowHeight : MonoBehaviour {
	
	public GameObject target;

	// Cache the GUIText object
	GUIText text;
	// Track the bext height so far
	float maxHeight = 0f;

	// Use this for initialization
	void Start () {
		// Do some error checking
		if (target == null) {
			Debug.LogError("Missing target in ShowHeight");
			Destroy (this);
		} else {
			text = GetComponent<GUIText>();
		}
	}
	
	// Update is called once per frame
	void Update () {
		// If the target gets destroyed, stop tracking it
		if (target == null) {
			Destroy(this);
			return;
		}

		// Update the max height if the current height is higher
		if (target.transform.position.y > maxHeight) {
			maxHeight = target.transform.position.y;
		}

		// Display the height with one decimal place
		text.text = string.Format("Height: {0:f1} Speed:{1:f1}", maxHeight, target.rigidbody2D.velocity.y); 
	}
}
