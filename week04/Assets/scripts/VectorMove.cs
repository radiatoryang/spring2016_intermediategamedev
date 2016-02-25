using UnityEngine;
using System.Collections;

public class VectorMove : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if ( Input.GetKey(KeyCode.UpArrow) ) {
			// time.deltaTime makes things "framerate independent"
			transform.Translate( 0f, 0f, 5f * Time.deltaTime );
		}

		// turning left
		if ( Input.GetKey(KeyCode.LeftArrow ) ) {
			transform.Rotate(0f, -180f * Time.deltaTime, 0f );
		}
		// turning right
		if ( Input.GetKey(KeyCode.RightArrow ) ) {
			transform.localEulerAngles += new Vector3( 0f, 180f * Time.deltaTime, 0f );
		}
	}
}
