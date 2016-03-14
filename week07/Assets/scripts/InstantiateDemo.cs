using UnityEngine;
using System.Collections;

public class InstantiateDemo : MonoBehaviour {

	public Transform originalThing;
	int numberOfClonesSoFar = 0;
	
	// Update is called once per frame
	void Update () {
		if ( numberOfClonesSoFar < 1000 ) {
			Vector3 randomPosition = new Vector3( Random.Range(-5f, 5f),
												  Random.Range(-5f, 5f),
												  Random.Range(-5f, 5f)
												);
			Quaternion randomRotation = Quaternion.Euler( Random.Range(0f, 360f), 
														  Random.Range(0f, 360f), 
														  Random.Range(0f, 360f) 
														);
			Transform newClone = (Transform)Instantiate( originalThing, randomPosition, randomRotation);
			newClone.localScale = Random.value * Vector3.one; // Random.value is a shortcut for Random.Range(0f, 1f)
			newClone.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
			numberOfClonesSoFar += 1;
		}

	}
}
