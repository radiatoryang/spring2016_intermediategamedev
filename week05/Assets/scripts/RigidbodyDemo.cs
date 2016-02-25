using UnityEngine;
using System.Collections;

public class RigidbodyDemo : MonoBehaviour {

	Rigidbody rBody;

	void Start () {
		rBody = GetComponent<Rigidbody>(); // cache reference
	}

	// if you want to do Physics forces, do it in FIXEDUPDATE
	void FixedUpdate () {
		// grab player input... see ControllerDemo.cs for detailed notes
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");

		Vector3 forwardForce = vertical * transform.forward * Time.deltaTime * 1000f;
		rBody.AddForce( forwardForce );

		transform.Rotate( 0f, horizontal * 90f * Time.deltaTime, 0f );
	}
}
