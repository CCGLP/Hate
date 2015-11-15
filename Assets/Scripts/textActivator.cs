using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class textActivator : MonoBehaviour {
	public GameObject text;
	public float delayTime;
	public string[] conver;
	public string nextLevel;
	public bool isEndofLevel;
	public bool isParanoia = false;
	private bool textpersist = false;

	Text texto;
	private int TriggerOut = 0;

	void Awake(){
		texto = text.GetComponent<Text> ();
		if (isParanoia) {
			text.SetActive (true);
			StartCoroutine("textChanger");
		}
	}

	void OnTriggerEnter (Collider other){
		if (!isParanoia && !textpersist) {
			text.SetActive (true);
			textpersist= true;
			StartCoroutine ("textChanger");
		}

	}

	void OnTriggerExit(Collider other){

		//StopCoroutine ("textChanger");
		TriggerOut++;

		if (TriggerOut >= 4) {
			StartCoroutine("Down");
		}
	}
	IEnumerator textChanger(){
		texto.text = "";
		yield return new WaitForSeconds(delayTime);
		for (int i = 0; i < conver.Length; i++) {
			texto.text = conver[i];
			yield return new WaitForSeconds(delayTime);
		}
		StartCoroutine("Down");
	}

	IEnumerator Down(){
		text.SetActive (false);
		yield return new WaitForSeconds (2);
		if (isEndofLevel)
			Application.LoadLevel (nextLevel);

		
	}
}
