using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StopwatchGame : MonoBehaviour {

	float timeHeldDown = 0f;
	
	// Update is called once per frame
	void Update () {
		GetComponent<Text>().text = "HOLD DOWN SPACE FOR EXACTLY 10 SECONDS";

		// if the player is holding down the space bar...
		if ( Input.GetKey(KeyCode.Space) ) {
			// then give the player some points
			timeHeldDown += Time.deltaTime;
			// Time.deltaTime is the duraton of the frame in seconds
		}

		GetComponent<Text>().text += "\n\n" + timeHeldDown.ToString();

		// CHEAT MODE OMG
		if ( Input.GetKeyDown(KeyCode.C) ) {
			timeHeldDown = 10f;
		}
	}
}
