﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// To type the next 4 lines, start by typing /// and then Tab.
/// <summary>
/// Keeps a GameObject on screen.
/// Note that this ONLY works for an orthographic Main Camera at [ 0, 0, 0 ].
/// </summary>
public class BoundsCheck : MonoBehaviour { // a
	[Header("Set in Inspector")]
	public float radius = 1f;
	
	[Header("Set Dynamically")]
	public float camWidth;
	public float camHeight;
	
	void Awake() {
		camHeight = Camera.main.orthographicSize; // b
		camWidth = camHeight * Camera.main.aspect; // c
	}//end Awake()
	
	void LateUpdate () { // d
		Vector3 pos = transform.position;if (pos.x > camWidth - radius) {
		pos.x = camWidth - radius;
		}
		if (pos.x < -camWidth + radius) {
		pos.x = -camWidth + radius;
		}
		if (pos.y > camHeight - radius) {
		pos.y = camHeight - radius;
		}
		if (pos.y < -camHeight + radius) {
		pos.y = -camHeight + radius;
		}
		transform.position = pos;
	}//end LateUpdate()
	
		// Draw the bounds in the Scene pane using OnDrawGizmos()
	void OnDrawGizmos () { // e
		if (!Application.isPlaying) return;
		Vector3 boundSize = new Vector3(camWidth* 2, camHeight* 2, 0.1f);
		Gizmos.DrawWireCube(Vector3.zero, boundSize);
	}//end OnDrawGizmos

}