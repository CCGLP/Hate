using UnityEngine;
using System.Collections;

public class PlayerTeenager : MonoBehaviour {
	private bool isAtReach = false;
	private GameObject objective;
	private bool killer = false;
	public string GoodLevel;
	public string BadLevel;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (isAtReach && Input.GetButton ("Fire1")) {
			Destroy (objective);
			isAtReach = false;
			objective = null;
			killer = true;
		}
	}

	void OnTriggerEnter (Collider other){

		if (other.CompareTag ("Bully")) {
			objective = other.gameObject;
			isAtReach = true;
		} else if (other.CompareTag ("Finish") && !killer) {
			Application.LoadLevel (GoodLevel);
		} else if (other.CompareTag ("Finish")) {
			Application.LoadLevel (BadLevel);
		}

	}

	void OnTriggerExit (Collider other){
		if (other.CompareTag ("Bully")) {
			objective = null;
			isAtReach= false;
		}
	}




}
