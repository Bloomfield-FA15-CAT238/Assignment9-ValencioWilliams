﻿using UnityEngine;
using System.Collections;

public class Win2 : MonoBehaviour {
	public GameController gameController;
	public GameObject respawnPoint;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		Application.LoadLevel (2);
		//gameController.Win();

	}
}
