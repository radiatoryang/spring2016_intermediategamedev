using UnityEngine;
using System.Collections;

// when the sphere is able to see the cylinder,
// the sphere should grow in size with ANGER

// put this script on the Sphere
public class HideAndSeekDemo : MonoBehaviour {

	public Transform cylinder; // assign in Inspector
	
	// Update is called once per frame
	void Update () {
		// STEP 1: make Ray
		Ray losRay = new Ray( transform.position, (cylinder.position - transform.position) );
		// STEP 2: init RaycastHit
		RaycastHit rayHitInfo = new RaycastHit();
		// STEP 2B: calculate distance, otherwise we might hit a wall behind cylinder
		float distance = (cylinder.position - transform.position).magnitude;
		Debug.DrawLine( cylinder.position, transform.position, Color.yellow );
		// STEP 3: cast your Ray
		if ( Physics.Raycast( losRay, out rayHitInfo, distance ) ) {
			if ( rayHitInfo.collider.tag == "Cylinder" ) {
				// OMG IT'S A CYLINDER, GET MAD
				transform.localScale *= 1.01f;
			} else {
				// IT'S NOT A CYLINDER, soooooo whatever
			}
		}
	}
}
