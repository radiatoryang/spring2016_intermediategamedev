using UnityEngine;
using System.Collections;

public class ControllerDemo : MonoBehaviour {

	CharacterController myController;

	void Start () {
		myController = GetComponent<CharacterController>();
	}

	void Update () {
		// GetAxis simulating a virtual joystick between Left/Right, A/D, W/S
		// spit out a number between -1f and 1f... 0 = nothing is pressed
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical"); // up/down, W/S

		// do movement now
		Vector3 movement = transform.forward * 5f * vertical;
		myController.Move( (movement + Physics.gravity * 2f) * Time.deltaTime );

		// do turning
		transform.Rotate( 0f, horizontal * 90f * Time.deltaTime, 0f );
	}
}
