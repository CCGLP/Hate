using UnityEngine;
using System.Collections;

public class balaBehaviour : MonoBehaviour {
	private Transform target;
	private Vector3 direction;
	private Rigidbody rb;
	private float speed = 6;
	private KillerBully kb;
	// Use this for initialization
	void Start () {
		target = GameObject.FindGameObjectWithTag ("Player").transform;
		rb = GetComponent<Rigidbody> ();
		direction =  target.position - this.transform.position;
		direction.Normalize();
		kb = GameObject.Find ("KillerBully").GetComponent<KillerBully>();


	}
	
	// Update is called once per frame
	void FixedUpdate () {

		rb.MovePosition (this.transform.position + (direction * speed * Time.deltaTime));

	}


	void OnCollisionEnter(Collision other){
		if (other.gameObject.CompareTag("Player")){
			Destroy(other.gameObject);
			Application.LoadLevel(kb.previousLevel);

		}

		Destroy(this.gameObject);

	}
}
