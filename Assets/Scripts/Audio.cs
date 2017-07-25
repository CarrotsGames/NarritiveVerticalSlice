using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour {
	public AudioClip audio;
	public float audioVolume = 1f;

	void OnTriggerEnter (){
		AudioSource.PlayClipAtPoint (audio, transform.position, audioVolume);
	}

	void OnTriggerExit (){
		Destroy (this.gameObject);
	}
}
