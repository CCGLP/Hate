using UnityEngine;
using System.Collections;

public class youAreTheMonster: MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.Find ("Chinese") == null) {
			Application.LoadLevel("Bad_Final");
		}
		
	}
}
