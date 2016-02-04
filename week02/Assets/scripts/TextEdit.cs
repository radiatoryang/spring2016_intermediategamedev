using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextEdit : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Text>().text = "Hola Mundo";
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Text>().text += "Trump 2016 World domination";
		Debug.Log( GetComponent<Text>().text.Length );
	}
}
