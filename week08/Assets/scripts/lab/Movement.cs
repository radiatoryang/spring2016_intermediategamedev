using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	void FixedUpdate () {
		// Movement.cs script:
//		FIXED UPDATE:
//		set rigidbody velocity equal to [current forward direction] * 10f + Physics.gravity
		GetComponent<Rigidbody>().velocity = transform.forward * 10f + Physics.gravity;
//		declare a var of type Ray, called "moveRay" that starts from [current position] and goes [current forward direction]
		Ray moveRay = new Ray( transform.position, transform.forward );
//		// a spherecast is like a thick raycast... google it!
//		if Physics.Spherecast with moveRay of radius 1 for distance 3 is TRUE... (if there is an obstacle in front of us...)
		if ( Physics.SphereCast( moveRay, 0.5f, 3f ) ) {
//			then randomly turn 90 degrees left or right (around Y axis)
			int randomNumber = Random.Range(0,2); // it will NEVER be 2
			if ( randomNumber == 0 ) {
				transform.Rotate(0f, 90f, 0f);
			} else {
				transform.Rotate(0f, -90f, 0f );
			}
		}
	}

}
