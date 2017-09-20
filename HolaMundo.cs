using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour {
	int numero = 0;
	//float nDecimal;
	//string Cadena;


	void SumarNumero (){
		numero++;
	}

	void RestarNumero (){
		numero--;
	}

	// Use this for initialization
	void Start () {
		//numero = 1000;
		//nDecimal = 7.5f;
		//Cadena = "Hola Mundo";
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown (KeyCode.UpArrow)){
			SumarNumero ();
			print (numero);
		}else if (Input.GetKeyDown (KeyCode.DownArrow)){
			RestarNumero ();
			print (numero);
		}
		
		/*bool enter = Input.GetKeyDown (KeyCode.Return);
		bool arriba = Input.GetKeyDown (KeyCode.UpArrow);
		bool abajo = Input.GetKeyDown (KeyCode.DownArrow);
		bool izquierda = Input.GetKeyDown (KeyCode.LeftArrow);
		bool derecha = Input.GetKeyDown (KeyCode.RightArrow);

		if (enter) {
			print ("Has apretado enter");
		} else if (arriba) {
			print ("Has apretado la flecha arriba");
		} else if (abajo) {
			print ("Has apretado la flecha abajo");
		}else if (izquierda) {
			print ("Has apretado la flecha izquierda");
		}else if (derecha) {
			print ("Has apretado la flecha derecha");
		}

		/*switch()
		{
		case Input.GetKeyDown (KeyCode.Return):
			print ("Has apretado enter");
			break;
		case Input.GetKeyDown (KeyCode.UpArrow):
			print ("Has apretado la flecha arriba");
			break;
		case Input.GetKeyDown (KeyCode.DownArrow);'
			print ("Has apretado la flecha abajo");
			break;
		}*/

		
		//print ("Hola Mundo " + numero);
		//numero++; //incremento la variable numero en 1
	}
}
