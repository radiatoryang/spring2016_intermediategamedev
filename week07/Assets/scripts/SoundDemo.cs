using UnityEngine;
using System.Collections;

public class SoundDemo : MonoBehaviour {

	AudioSource myAudio;

	// define public AudioClips when you have multiple sounds to play
	public AudioClip myExplosionSound;

	// Use this for initialization
	void Start () {
		myAudio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if ( Input.GetKeyDown(KeyCode.Space) ) {
			// avoid doing one-shot sounds like this, or else
			// if the player taps fast twice, you'll only hear it once
//			if ( myAudio.isPlaying == false ) {
//				myAudio.Play();
//			}
			myAudio.PlayOneShot( myAudio.clip, 0.5f );
		}

		// this is the preferred way
		if ( Input.GetKeyDown(KeyCode.E) ) {
			myAudio.PlayOneShot( myExplosionSound, 0.5f) ;
		}

		// play a sound WITHOUT an AudioSource (*not* recommended)
		if ( Input.GetKeyDown(KeyCode.B) ) {
			AudioSource.PlayClipAtPoint( myExplosionSound, new Vector3(10f, 0f, 0f), 1f );
		}


	}
}
