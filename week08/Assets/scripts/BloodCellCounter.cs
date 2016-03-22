using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class BloodCellCounter : MonoBehaviour {

	public Text myText;

	// Use this for initialization
	void Start () {
		myText.text = "last blood cell was at: " + transform.position.ToString();
	}

}
