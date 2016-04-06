using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ListDestroyDemo : MonoBehaviour {

	public List<string> listOfFailingStudents = new List<string>();

	// Use this for initialization
	void Start () {
		listOfFailingStudents.Add("Noah");
		listOfFailingStudents.Add("Elijah");
		listOfFailingStudents.Add("Elijah");
		listOfFailingStudents.Add("Elijah");
		listOfFailingStudents.Add("Elijah");
		listOfFailingStudents.Add("Elijah");
		listOfFailingStudents.Add("Elijah");
		listOfFailingStudents.Add("Elijah");
		listOfFailingStudents.Add("Erik");
	}
	
	// Update is called once per frame
	void Update () {
		// print every item out to the console
		if ( Input.GetKeyDown(KeyCode.Space) ) {
			foreach ( string studentName in listOfFailingStudents ) {
				Debug.Log(studentName);
			}
		}

		// a bit trickier: how to remove certain list items with foreach
		if ( Input.GetKeyDown(KeyCode.A) ) {
			List<string> successfulStudents = new List<string>();

			foreach ( string studentName in listOfFailingStudents ) {
				if ( studentName.StartsWith("E") ) {
					// you cannot remove items directly from a list while we are foreach'ing
					// the line of code below will give you an error
					// listOfFailingStudents.Remove( studentName );

					// instead, make a list of items to remove...
					successfulStudents.Add( studentName );
				}
			}

			// ... and then in a separate foreach loop, remove them
			foreach ( string goodStudent in successfulStudents ) {
				listOfFailingStudents.Remove(goodStudent);
			}
		}

	}
}
