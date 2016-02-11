using UnityEngine;
using System.Collections;

public class VectorMove : MonoBehaviour {

	// "public" exposes a variable to the Unity inspector
	// Unity will now IGNORE the code value, and use Inspector value instead
	public float speed = 0.02f;
	
	// Update is called once per frame
	void Update () {
		// "Time.deltaTime" = is the duration of the frame in seconds
		// 10 FPS, dT = 0.1f.... 100 FPS, dt = 0.01f
		// slower framerate means dT gets BIGGER
		// faster framerate means dT gets SMALLER
		transform.position += new Vector3( 0f, speed, 0f ) * Time.deltaTime;
		// multiply by Time.deltaTime to make it framerate INDEPENDENT

		// rotate 90 degrees per second on the Y axis
		transform.Rotate( 0f, 90f * Time.deltaTime, 0f );

	}
}
