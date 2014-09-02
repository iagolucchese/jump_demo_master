using UnityEngine;
using System.Collections;

// Gives the parent object some initial force (by default, up)
public class Impulse : MonoBehaviour {

	public Vector2 initialForce = new Vector2(0, 300);

	// Use this for initialization
	void Start () {
		rigidbody2D.AddForce(initialForce);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
