using UnityEngine;
using System.Collections;

public class KillAll : MonoBehaviour {
	private bool isAtReach = false;
	private GameObject objective;
	private bool killer = false;
	public string GoodLevel;
	public string BadLevel;
	private int killThemAll = 0;
	public int killCount;
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
			killThemAll++;
		}
		if (killThemAll >=killCount) {
			Application.LoadLevel(GoodLevel);
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
