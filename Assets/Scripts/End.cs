using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class End : MonoBehaviour {

	public Image game;
	public Animator screen;


	// Use this for initialization
	void Start () {
		game.enabled = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider other){
		game.enabled = true;
	}
	void OnTriggerExit (Collider other){
		Application.Quit ();
	}
}
