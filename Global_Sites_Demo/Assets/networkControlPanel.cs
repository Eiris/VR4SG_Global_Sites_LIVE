﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class networkControlPanel : NetworkBehaviour {

	// Use this for initialization
	void Start () {
		if (!isServer) {
			gameObject.SetActive (false);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
