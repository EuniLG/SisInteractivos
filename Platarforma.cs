using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platarforma : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D collisino){
		print ("Ha ocurrido un evento Colision");
	}

	void OnTriggerEnter2D(Collider2D collider){
		print ("Ha ocurrido un evento Trigger");
	}

}
