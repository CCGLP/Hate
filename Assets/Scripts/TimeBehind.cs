using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeBehind : MonoBehaviour {
	public float tiempoTotal;
	public Text text;
	public string previousLevel;

	
	// Update is called once per frame
	void Update () {
		tiempoTotal -= Time.deltaTime;
		if (text!=null)
			text.text = "Time Left: " + (int)tiempoTotal;
		if (tiempoTotal <= 0) {
			Application.LoadLevel(previousLevel);
		}
	}
}
