using UnityEngine;
using System.Collections;

public class RaycastMouseLook : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		// simple mouse-look:
		// first, get mouse velocity
		float mouseY = Input.GetAxis("Mouse Y");
		float mouseX = Input.GetAxis("Mouse X");
		// then we rotate camera based on mouse velocity
		transform.Rotate( -mouseY, mouseX, 0f );
		// correct for rolling
		transform.localEulerAngles = new Vector3( transform.localEulerAngles.x,
												  transform.localEulerAngles.y,
												  0f
												);
		// if we click, lock and hide the cursor
		if ( Input.GetMouseButtonDown(0) ) {
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = false;
		}

		// now let's actually raycast? see RaycastDemo.cs for an introduction
		Ray ray = new Ray( transform.position, transform.forward );
		RaycastHit rayHitInfo = new RaycastHit();
		if ( Physics.Raycast( ray, out rayHitInfo, 1000f ) ) {
			if ( Input.GetMouseButtonDown(0) ) {
				rayHitInfo.transform.localScale *= 0.9f; // shrink thing we clicked
			}
		}

	}
}
