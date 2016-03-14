using UnityEngine;
using System.Collections;

public class RandomPosition : MonoBehaviour {

	public Transform cube; // assign in Inspector

	// Use this for initialization
	void Start () {
		//Random.seed = 4; // "seed" guarantees a certain sequence of randomness
		float randomNumber = Random.Range(0f, 1f);
		Debug.Log( randomNumber.ToString() );
	}
	
	// Update is called once per frame
	void Update () {
		// the below use of Random.Range will be 50% 0, 50% 1, and 0% 2
		Debug.Log( Random.Range(0, 2) );

		Vector3 randomPosition = new Vector3( Random.Range(-5f, 5f),
											  Random.Range(-5f, 5f),
											  Random.Range(-5f, 5f) 
										 	);
		transform.position = cube.position + randomPosition;
	}
}
