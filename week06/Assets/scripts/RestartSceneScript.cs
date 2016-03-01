using UnityEngine;
using System.Collections;

using UnityEngine.SceneManagement;

public class RestartSceneScript : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		if ( Input.GetKeyDown(KeyCode.R) ) {
			// reload the currently loaded scene
			SceneManager.LoadScene( SceneManager.GetActiveScene().name );
		}
	}
}
