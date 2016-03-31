using UnityEngine;
using System.Collections;

using System.Collections.Generic; // you need this line here to use Lists

// the job of the FishGod is to
// - create fish
// - command fish

public class FishGod : MonoBehaviour {

	public Fish fishPrefab; // assign in Inspector
	List<Fish> listOfFish = new List<Fish>();

	// Use this for initialization
	void Start () {
		while ( listOfFish.Count < 1000 ) { // make 1000 fish instantly within 1 frame
			Fish newFish = (Fish)Instantiate( fishPrefab, Random.insideUnitSphere * 10f, Random.rotation );
			listOfFish.Add( newFish ); // add the new fish to our list of fish
		}
	}
	
	// Update is called once per frame
	void Update () {
		if ( Input.GetKeyDown(KeyCode.Space) ) {
			foreach ( Fish thisFish in listOfFish ) {
				// tell every fish to go to a random point inside an imaginary sphere of radius 10
				thisFish.destination = Random.insideUnitSphere * 10f;
			}
		}

		// TODO: make it so that fish go wherever we click on the backgroundCube
		// 1: raycast based on mouse cursor
		// 2: use a for loop to command all fish to goto raycast point
		Ray mouseRay = Camera.main.ScreenPointToRay( Input.mousePosition );
		RaycastHit mouseRayHit = new RaycastHit();

		if ( Input.GetMouseButtonDown(0) && 
			 Physics.Raycast( mouseRay, out mouseRayHit, 1000f ) ) 
		{
			foreach ( Fish beyonce in listOfFish ) {
				beyonce.destination = mouseRayHit.point;
			}
		}

	}
}
