using UnityEngine;
using System.Collections;

public class GroundedJumpDemo : MonoBehaviour {

	bool grounded = false; // keep track whether we are on ground or not

	void Update () {
		// STEP 1: construct the ray
		Ray groundedRay = new Ray( transform.position, Vector3.down );

		// STEP 2: setup your RaycastHit var
		// but for now, we can skip it
		// we may want this later if we want to detect which footstep sounds to play

		// STEP 3: cast your ray
		if ( Physics.Raycast( groundedRay, 1.1f ) ) {
			grounded = true;
		} else {
			grounded = false;
		}
			
	}
	
	// FixedUpdate is called once per physics frame
	void FixedUpdate () {
		// jump code: jump if we press [space] AND if grounded is true
		if ( Input.GetKeyDown(KeyCode.Space) && grounded == true ) {
			GetComponent<Rigidbody>().velocity += Vector3.up * 10f;
		}
	}
}
