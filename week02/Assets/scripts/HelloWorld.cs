using UnityEngine;
using System.Collections;

public class HelloWorld : MonoBehaviour {

	// any code in Start will happen once at the 
	// beginning of the game and never again
	void Start () {
		Debug.Log( "Hello World" );
	}
	
	// Update happens constantly, every frame, forever
	void Update () {
		Debug.Log( "Bonjour Monde" );
	}
}
