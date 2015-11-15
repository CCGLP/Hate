using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
	private bool nowTarget;
	public Transform player;
	public GameObject bala;
	private float timeBet = 0;
	public int timeBetweenShoots =4;
	private Rigidbody rbbala;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		timeBet += Time.deltaTime;
		if (nowTarget && timeBet>timeBetweenShoots || ((transform.position - player.position).magnitude < 8 ) && timeBet> timeBetweenShoots) {
			shoot ();
			nowTarget = true;
			timeBet = 0;
		}
	
	}




	void shoot(){
		Instantiate (bala, this.transform.position, this.transform.rotation);

	}
}
