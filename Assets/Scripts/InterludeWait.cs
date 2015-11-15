using UnityEngine;
using System.Collections;

public class InterludeWait : MonoBehaviour {
	private bool notYet = true;
	public string levelName;
	public float delayStart = 4f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.anyKey && notYet){
			notYet = false;
			StartCoroutine("Charge");
		}
	}

	IEnumerator Charge(){
		yield return new WaitForSeconds (delayStart);
		Application.LoadLevel(levelName);


	}



}
