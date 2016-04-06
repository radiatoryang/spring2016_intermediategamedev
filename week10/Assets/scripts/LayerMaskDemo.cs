using UnityEngine;
using System.Collections;

public class LayerMaskDemo : MonoBehaviour {

	public LayerMask raycastMask; // assign in Inspector
	
	// Update is called once per frame
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay( Input.mousePosition );
		RaycastHit rayHitInfo = new RaycastHit();

		if ( Physics.Raycast( ray, out rayHitInfo, 1000f, raycastMask ) ) {
			rayHitInfo.transform.localScale *= 1.01f; // make WHATEVER grow bigger
		}
	}

}
