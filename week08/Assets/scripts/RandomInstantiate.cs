using UnityEngine;
using System.Collections;

public class RandomInstantiate : MonoBehaviour {

	public Transform thingIWantToClone; // assign in Inspector
	int clonesMade = 0;
	
	// Update is called once per frame
	void Update () {
		if ( clonesMade < 1000 ) {
			Instantiate( thingIWantToClone, Random.insideUnitSphere * 5f, Random.rotation );
			clonesMade++;
		}
	}
}
