using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public Transform target;
	public float smoothing = 5f; //Lag de la camara
	
	Vector3 offset;
	
	void Start(){
		offset = transform.position - target.position; //Hay que hacer que la camara siga al jugador, con offset
	}
	
	void FixedUpdate(){ //Lo hacemos con FixedUpdate por que el jugador tambien se mueve con esta funcion, queremos que se muevan al mismo tiempo
		Vector3 targetCamPos = target.position + offset; 
		transform.position = Vector3.Lerp (transform.position, targetCamPos, smoothing * Time.deltaTime); //Muevete desde donde estas (transform.position) a donde quiero que estes en tantos segundos
		
		
	}

}
