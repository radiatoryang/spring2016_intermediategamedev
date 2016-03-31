using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// TODO:
// - plant TreeA if we left-click on the ground
// - plant TreeB if we right-click on the ground

public class ForestManager : MonoBehaviour {

	public Transform treeA, treeB; // set in Inspector
	List<Transform> listOfTrees = new List<Transform>();
	
	// Update is called once per frame
	void Update () {
		Ray mouseRay = Camera.main.ScreenPointToRay( Input.mousePosition );
		RaycastHit mouseRayHit = new RaycastHit();

		if ( Physics.Raycast( mouseRay, out mouseRayHit, 1000f ) ) {
			if ( Input.GetMouseButtonDown(0) ) {
				Transform newTree = (Transform)Instantiate( treeA, mouseRayHit.point, Quaternion.identity );
				listOfTrees.Add(newTree);
			}
			if ( Input.GetMouseButtonDown(1) ) {
				Transform newTree = (Transform)Instantiate( treeB, mouseRayHit.point, Quaternion.identity );
				listOfTrees.Add(newTree);
			}
		}

		// TODO: let us press UpArrow / DownArrow to grow / shrink all trees
		if ( Input.GetKeyDown(KeyCode.DownArrow) ) {
			foreach( Transform tree in listOfTrees ) {
				// tree.localScale -= new Vector3( 0.1f, 0.1f, 0.1f); // shrink at fixed rate
				tree.localScale *= 0.9f; // shrink it to 90% of its current scale
			}
		}

		if ( Input.GetKeyDown(KeyCode.UpArrow) ) {
			foreach( Transform tree in listOfTrees ) {
				tree.localScale *= 1.1f; // grow to 110% of its current scale
			}
		}

	}
}
