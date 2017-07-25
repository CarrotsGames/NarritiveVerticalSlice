using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other){
		GameObject myGameObject = new GameObject ("Roof");
		Rigidbody gameObjectRigidBody = myGameObject.AddComponent<Rigidbody> ();
		gameObjectRigidBody.mass = 5;
	}
}
