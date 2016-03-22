using UnityEngine;
using System.Collections;

public class RaycastDemo : MonoBehaviour {

	public Transform sphere; // assign in Inspector
	
	// Update is called once per frame
	void Update () {
		// step 1: construct your "Ray"
		Ray ray = Camera.main.ScreenPointToRay( Input.mousePosition );
		// ScreenPointToRay is a special function that will take a pixel
		// coordinate on screen, and generate a ray based on it

		// step 2: initialize your RaycastHit variable
		RaycastHit rayHitInfo = new RaycastHit(); // a "constructor"
		// RaycastHit will tell you what you hit, and where, etc.

		// step 2b: debug draw / visualize the raycast
		Debug.DrawRay( ray.origin, ray.direction * 1000f, Color.yellow );

		// step 3: actually fire the Raycast now
		if ( Physics.Raycast( ray, out rayHitInfo, 1000f ) ) {
			// step 3b: debug draw a successful raycast
			Debug.DrawRay( ray.origin, ray.direction * rayHitInfo.distance, Color.red);

			// all code in here will assume we hit something
			sphere.position = rayHitInfo.point;

			// extra extra credit: "paint" only when we hold down the mouse button
			if ( Input.GetMouseButton(0) ) {
				// instantiate a sphere here?
				Transform newSphere = (Transform)Instantiate( sphere, rayHitInfo.point, Quaternion.identity );
				// extra credit: randomize the sphere's color as well?
				if ( Input.GetKey(KeyCode.Space) ) {
					newSphere.GetComponent<Renderer>().material.color = 
						Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
				} else {
					newSphere.GetComponent<Renderer>().material.color = 
						new Color( Random.value, Random.value, Random.value );
				}
			}
		}

	}
}
