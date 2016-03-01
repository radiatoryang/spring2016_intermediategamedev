using UnityEngine;
using System.Collections;

// need this line to use Scene Change code
using UnityEngine.SceneManagement; 

public class TitleScreen : MonoBehaviour {

	// "static" means this variable lives in the code instead of on a gameObject
	// this variable will persist beyond a scene change
	public static bool useNightmareMode = false;
	
	// Update is called once per frame
	void Update () {
		// if player pressed space....
		if ( Input.GetKeyDown(KeyCode.Space) ) {
			// ... then load the main game scene
			SceneManager.LoadScene( 1 );
		}

		if ( Input.GetKeyDown(KeyCode.N ) ) {
			// read aloud as "set useNightmareMode to NOT-useNightmareMode
			useNightmareMode = !useNightmareMode;
			Debug.Log("nightmare mode is enabled!!!");
		}
	}
}
