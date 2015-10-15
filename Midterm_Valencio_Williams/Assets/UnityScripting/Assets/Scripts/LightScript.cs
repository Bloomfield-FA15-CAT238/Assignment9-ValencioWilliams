using UnityEngine;
using System.Collections;

public class LightScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Light>().intensity = Random.Range (0.0f, 8.0f);

		bool objectThere = Physics.Raycast (transform.position, transform.forward, 10);

		RaycastHit objectHit;
		if (Physics.Raycast (transform.position, transform.forward, out objectHit)) {
			Debug.Log ("Destory " + objectHit.collider.gameObject.name + "!!!!");
			Destroy (objectHit.collider.gameObject);
		}
	}

	void OnTrigger ( Collider other ) {
	}
}
