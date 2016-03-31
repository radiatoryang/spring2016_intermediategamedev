using UnityEngine;
using System.Collections;

public class ButtonTest : MonoBehaviour {

	public Transform sphere;

	public void ToggleSphere () {
		sphere.gameObject.SetActive( !sphere.gameObject.activeInHierarchy );
	}

}
