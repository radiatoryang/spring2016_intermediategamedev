using UnityEngine;
using System.Collections;

public class DistanceDemo : MonoBehaviour {

	public Transform cube, sphere; // assign in Inspector
	
	// Update is called once per frame
	void Update () {
		// more code to write, but will tell you direction / orientation
		Vector3 vectorBetweenTwoPoints = (cube.position - sphere.position);
		if ( vectorBetweenTwoPoints.magnitude > 5f && vectorBetweenTwoPoints.magnitude < 10f ) {
			Debug.Log("YOU WIN YOU ARE WINNER");
			cube.gameObject.SetActive( false ); // disable the cube
		} else {
			Debug.Log("YOU LOSE, YoU ARETHE WORST");
			cube.gameObject.SetActive( true ); // enable the cube
		}

		// less code to write, but ONLY tells you distance, no directions
		float distance = Vector3.Distance( cube.position, sphere.position );
		Debug.Log("you are " + distance.ToString() + " units apart" );

	}
}
