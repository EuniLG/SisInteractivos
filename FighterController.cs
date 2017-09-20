using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterController : MonoBehaviour {

	public float speed = 5f;
	public float padding = 1f;
	public GameObject bullet;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		

	//movimiento vertical
	float hInput = Input.GetAxis("Horizontal");
	transform.position  += new Vector3(hInput * speed * Time.deltaTime, 0, 0);

	//movimiento vertical
	float vInput = Input.GetAxis("Vertical");
	transform.position  += new Vector3(0, vInput * speed * Time.deltaTime, 0);

		//clamping
		float newX = Mathf.Clamp(transform.position.x, -10 + padding, 10 - padding);
		float newY = Mathf.Clamp(transform.position.y, -10 + padding, 10 - padding);
		transform.position =  new Vector3(newX, newY, transform.position.z);

		//disparo
		if (Input.GetKeyDown (KeyCode.Space)) { //poner el disparador en marcha
			InvokeRepeating("Fire", 0.001f, 0.25f);

		} else if (Input.GetKeyUp (KeyCode.Space)){ //detener el disparador
			CancelInvoke("Fire");
		
		}

		}


	void Fire(){
		var fighter = GameObject.Find ("Fighter");
		if (fighter != null) {
			//Vector3 newPosition = fighter.transform.position + Vector3.up * 1.5f;
			Vector3 newPosition2 = fighter.transform.position + Vector3.left * 0.7f + Vector3.up * 0.5f;
			Vector3 newPosition3 = fighter.transform.position + Vector3.right * 0.7f + Vector3.up * 0.5f;	
			//Instantiate(bullet, newPosition, Quaternion.identity);
			Instantiate (bullet, newPosition2, Quaternion.identity);
			Instantiate (bullet, newPosition3, Quaternion.identity);
		}
		
	}
}

