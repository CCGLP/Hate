using UnityEngine;
using System.Collections;

public class KillerBully : MonoBehaviour {
	public string previousLevel;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision other){
		if (other.gameObject.CompareTag ("Player")) {
			Destroy (other.gameObject);
			Invoke("goPreviousLevel", 1.5f);
		}

	}

	void goPreviousLevel(){
		Application.LoadLevel (previousLevel);
	}
}
