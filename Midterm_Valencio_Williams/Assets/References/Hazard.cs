using UnityEngine;
using System.Collections;


public class Hazard : MonoBehaviour {
	public GameObject respawnPoint;
	public GameController Game;
	
	int death = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		/*while (Game.RespawnPlayer())
		{
			death = death + 1;
			print ("You have died: " + death);
		}
		*/

	}

	void OnTriggerEnter(Collider other) {
		//Game.RespawnPlayer();

		other.gameObject.transform.position = respawnPoint.transform.position;
	}



}
