using UnityEngine;
using System.Collections;

public class DeathZone : MonoBehaviour {

	// "activator" is the thing that entered the trigger
	// OnTriggerEnter will happen the first time I enter the trigger
	void OnTriggerEnter ( Collider activator ) {
		// Destroy ( activator.gameObject );
		if ( Time.time >= 30f ) {
			Debug.Log( "player took more than 30 seconds to enter trigger! player now gets bad ending");
		}
	}

	// OnTriggerStay happens as long as I'm in the trigger, constantly
	void OnTriggerStay ( Collider activator ) {
		// lose 2 health points every frame as long as I'm in this trigger
		activator.GetComponent<BasicPlayer>().healthPoints -= 2;
	}

	void OnTriggerExit () {

	}

}
