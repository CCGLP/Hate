using UnityEngine;
using System.Collections;

public class GorditoIsDead : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.Find ("Gordito") == null) {
			Application.LoadLevel("Level_11b");
		}
	
	}
}
