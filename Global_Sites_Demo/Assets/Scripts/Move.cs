﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour {

	Vector3 ray;
	Vector3 hit;
	public Button[] hingeJoints;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Camera.main == null)
			return;
		var ray = Camera.main.ViewportPointToRay(new Vector3 (0.5f, 0.5f, 5));
		RaycastHit hit;

		hingeJoints = GetComponentsInChildren<Button>();
	

		if (Physics.Raycast (ray, out hit) && Input.GetMouseButton (0)) {
			print(this.gameObject.GetComponent<Collider> ());
//			print(hit.collider);
			if (this.gameObject.GetComponent<Collider> () == hit.collider && hit.collider.tag != "button") {
				MoveObject ();
			}
		}
	}
		

	public void MoveObject(){
//		Debug.Log ("YOOOO");
		
		var raycast = Camera.main.ViewportToWorldPoint (new Vector3 (0.5f, 0.5f, 5));
		transform.position = raycast;
		transform.rotation = Quaternion.LookRotation(transform.position - Camera.main.transform.position);
	}
}
