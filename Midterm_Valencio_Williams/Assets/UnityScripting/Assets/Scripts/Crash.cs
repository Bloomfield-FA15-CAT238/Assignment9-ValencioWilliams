using UnityEngine;
using System.Collections;

public class Crash : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter( Collider other) {
		print ("Now in OnTriggerEnter");
	}
	
	void OnTriggerStay( Collider other) {
		other.transform.localScale = new Vector3 (0.1f, 0.1f, 0.1f);
		print ("Now in OnTriggerStay with the other object " + other.gameObject.name);
	}
	
	void OnTriggerExit( Collider other) {
		print ("Collision is over, nothing to see here!");
	}
	
}
