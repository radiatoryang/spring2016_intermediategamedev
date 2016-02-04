using UnityEngine;
using System.Collections;

using UnityEngine.UI; // you need this to talk to UI elements (like Text)

public class TappingGame : MonoBehaviour {

	int currentScore = 0;
	
	// Update is called once per frame
	void Update () {
		GetComponent<Text>().text = "TAPPING GAME. TAP [SPACE] TO WIN";

		// player input code
		if ( Input.GetKeyDown(KeyCode.Space) ) {
			currentScore++; // add a point to currentScore
		}

		// display player score
		GetComponent<Text>().text += "\n\nYOU HAVE WON <b><color=red>" + currentScore.ToString() + "</color></b> TIMES!";
	}
}
