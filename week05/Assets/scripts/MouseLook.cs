using UnityEngine;
using System.Collections;

public class MouseLook : MonoBehaviour {

	float rotationY;
	
	// Update is called once per frame
	void Update () {
		// if we aren't moving the mouse, these values are 0
		float mouseX = Input.GetAxis("Mouse X"); // moving left = -1
		float mouseY = Input.GetAxis("Mouse Y"); // moving down = -1

		// horizontal turning
		// 3 bugs to fix with this version:
		// 1) inverted or not inverted?
		// 2) clamp mouseY and constrain it
		// 3) un-roll the camera
//		transform.Rotate( mouseY * Time.deltaTime * 90f, 
//			              mouseX * Time.deltaTime * 90f, 
//			              0f );

		// ... ok, let's fix all those bugs...

		// horizontal movement
		transform.Rotate( 0f, mouseX * Time.deltaTime * 90f, 0f );

		// vertical movement
		rotationY += -mouseY * Time.deltaTime * 90f;
		rotationY = Mathf.Clamp( rotationY, -80f, 80f ); // so we don't look upside down
		transform.localEulerAngles = new Vector3( rotationY,
												  transform.localEulerAngles.y,
												  0f ); // setting Z to 0 un-rolls the camera

		// hide the cursor and lock it into the center of the screen
		if ( Input.GetMouseButtonDown(0) ) {
			Cursor.visible = false;
			Cursor.lockState = CursorLockMode.Locked;
		}

		if ( Input.GetKeyDown(KeyCode.Escape ) ) { // press ESC to unlock
			Cursor.visible = true;
			Cursor.lockState = CursorLockMode.None;
		}

	}
}
