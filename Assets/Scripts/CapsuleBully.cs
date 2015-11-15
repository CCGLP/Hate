using UnityEngine;
using System.Collections;

public class CapsuleBully : MonoBehaviour {
	private NavMeshAgent ag;
	private Transform player;
	private bool nowTarget = false;
	// Use this for initialization
	void Start () {
		ag = GetComponent<NavMeshAgent> ();
		player = GameObject.FindGameObjectWithTag ("Player").transform;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//With a little help of my cortocircuito friend
		if (nowTarget || (transform.position - player.position).magnitude < 8 ) {

			ag.SetDestination (player.position);
			nowTarget = true;
		}

	}


}
