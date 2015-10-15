using UnityEngine;
using System.Collections;

public class BasicScript : MonoBehaviour {
	public int showsUpInUnityEditor = 91;
	int doesNotShowUpUnUnityEditor = 123;

	public GameObject objectToManipulate;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		/*
		Input.GetAxis ("Axis Name");
		Input.GetAxisRaw ("Axis Name");
		Input.GetKey (KeyCode);
		Input.GetKeyDown (KeyCode);
		Input.GetMouseButton (buttonNumber);
		Input.GetButtonUp (KeyCode);
		*/
		//	transform.position = new Vector3 (10.0f, 10.0f, 10.0f);
		//	transform.rotation = new Quaternion (0.0f, 20.0f, 0.0f, 1.0f);
		/*
		objectToManipulate.transform.Rotate(new Vector3 (10.0f, 10.0f, 10.0f));
		transform.rotation = new Quaternion ();

		Quaternion fromRotation = transform.rotation;
		Quaternion toRotation = Quaternion.Euler (10.0f, 10.0f, 10.0f);
		transform.rotation = Quaternion.Lerp (fromRotation, toRotation, 1.0f);
		*/
		//print ( Random.Range(0.0f, 20.0f) );

		transform.localScale = new Vector3 (0.5f, 1.0f, 1.0f);
		/*JointTranslationLimits2D.

		rigidbody.velocity = new Vector3 (13.4f, 0.0f);

		rigidbody.mass = 1;
		rigidbody.drag = 0;
		rigidbody.angularDrag = 0.05;
		rigidbody.useGravity = true;
		rigidbody.isKinematic = false;
		rigidbody.interpolation = RigidbodyInterpolation.None;
		rigidbody.collisionDetectionMode = CollisionDetectionMode.Discrete;
		rigidbody.constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationX;
		*/

	}
}
