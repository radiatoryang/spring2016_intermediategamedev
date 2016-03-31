using UnityEngine;
using System.Collections;

public class Fish : MonoBehaviour {

	// "SerializeField" exposes a variable to Inspector without making it public
	[SerializeField] float stoppingDistance = 1f;
	[SerializeField] float speed = 5f;
	public Vector3 destination; // where the Fish is trying to go

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// visualize destination
		Debug.DrawLine( transform.position, destination, Color.yellow );

		float distance = Vector3.Distance( transform.position, destination );

		// handles movement
		if ( distance > stoppingDistance ) { // if we are far enough, then MOVE
			transform.position += Vector3.Normalize(destination - transform.position) 
								  * speed * Time.deltaTime;
			transform.LookAt ( destination );
		}
	}
}
