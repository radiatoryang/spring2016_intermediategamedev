using UnityEngine;
using System.Collections;

public class VectorControl : MonoBehaviour {

	public float speed = 5f;
	public float turnSpeed = 360f;
	
	// Update is called once per frame
	void Update () {
		// moving forward by pressing W
		if ( Input.GetKey( KeyCode.W ) ) {
			transform.position += transform.forward * speed * Time.deltaTime;
		}

		// moving backward by pressing S
		if ( Input.GetKey( KeyCode.S ) ) {
			transform.position += -transform.forward * speed * Time.deltaTime;
		}

		// rotate left by pressing A
		if ( Input.GetKey(KeyCode.A) ) {
			transform.Rotate( 0f, -turnSpeed * Time.deltaTime, 0f );
		}

		// rotate right by pressing D
		if ( Input.GetKey(KeyCode.D) ) {
			transform.Rotate( 0f, turnSpeed * Time.deltaTime, 0f );
		}
	}
}
