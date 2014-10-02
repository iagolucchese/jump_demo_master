﻿using UnityEngine;
using System.Collections;

// Makes this object follow the mouse
public class MouseFollow : MonoBehaviour {

	public bool followX = true;
	public bool followY = true;
	public float speedOfFollow = 0.05f;

	public float tiltMinDistance = 0.2f;
	public float tiltMaxDistance = 1f;
	public float tiltDegrees = 30f;

	// Every frame, jump to the current mouse position
	void Update () {

		Vector3 mousePos = Input.mousePosition;
		// Convert from screen coordinates to world coordinates
		Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);
		// Ignore the z-position since we're working in 2D
		worldPos.z = transform.position.z;

		//tilt code
		//transform.LookAt(worldPos);

		//follow code
		worldPos = (worldPos - transform.position) * speedOfFollow + transform.position;

		// Lock the x or y axes if they're not being followed
		if (!followX) {
			worldPos.x = transform.position.x;
		}
		if (!followY) {
			worldPos.y = transform.position.y;
		}

		// Set the position
		transform.position = worldPos;
	}
}