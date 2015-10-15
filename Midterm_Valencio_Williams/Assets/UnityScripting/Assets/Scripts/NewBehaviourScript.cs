// Using Section:
using UnityEngine;
using System.Collections;

// Class Section:
public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int counter = 2;
		Debug.Log ("Start " + counter);
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("Normal Update");
	}

	void FixedUpdate () {
		Debug.Log ("Fixed...");
	}

	void Awake () {
		Debug.Log ( "message" );
		print( "message" );
	}
}
