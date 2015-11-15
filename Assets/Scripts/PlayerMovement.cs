using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float speed = 4f;
	Vector3 movement;
	Rigidbody rb;

	void Awake () {
		rb = GetComponent<Rigidbody> ();

	}
	
	// FixedUpdate se actualiza despues de cada ciclo del motor de fisicas
	void FixedUpdate () {
		float h = Input.GetAxisRaw ("Horizontal");
		float v = Input.GetAxisRaw ("Vertical");
		Move (h, v);
		//Pensar en codigo de rotacion, si es necesario. hasta aqui, mover

	}


	void Move(float h, float v){
		movement.Set (h, 0f, v);
		movement = movement.normalized * speed * Time.deltaTime;
		rb.MovePosition (transform.position + movement);

	}
}
