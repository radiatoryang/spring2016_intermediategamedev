using UnityEngine;
using System.Collections;

public class BasicPlayer : MonoBehaviour {

	public int healthPoints = 100; // DeathZone will subtract health from player

	void Start () {
		if ( TitleScreen.useNightmareMode == true ) {
			healthPoints = 1; // nightmareMode is really hard
		}
	}

	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis( "Horizontal" ); // A/D, Left/Right
		float v = Input.GetAxis( "Vertical" ); // W/S, Up/Down

		// forward movement
		transform.Translate( 0f, 0f, v * Time.deltaTime * 5f );

		// turning
		transform.Rotate( 0f, h * Time.deltaTime * 90f, 0f );

		// player death detection
		if ( healthPoints <= 0 ) { // if health points is less than 0...
			Destroy ( gameObject ); // destroy player
		}
	}
}
