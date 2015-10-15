using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	public GameObject prefab;

	void Update () {
		if (Input.GetKeyDown (KeyCode.Backspace)) {
			Instantiate (prefab);
		} else if (Input.GetKeyDown (KeyCode.Space)) {
			Instantiate (prefab, this.transform.position, this.transform.rotation );
		}
	}
}
