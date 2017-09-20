using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Diapositiva{

	public string titulo;
	public string descripcion;
	public Sprite fotografia;

	//constructor
	public Diapositiva(string _titulo, string _descripcion, string _fotografia)
	{
		
		titulo = _titulo;
		descripcion = _descripcion;
		fotografia = Resources.Load <Sprite> (_fotografia);
	}


	}
	public class Controlador : MonoBehaviour {

	public  Text Tittle;
	public  Text Description;
	public  Image Fotografia;

			public List <Diapositiva> Diapositivas = new List <Diapositiva>();

			public int actual= 0;

	// Use this for initialization
	void Start () {
		/*Tittle.text = "Everest";
		Description.text = "8.848m";
		Fotografia.sprite = Resources.Load<Sprite>("Imagen/everest");
		print (Fotografia.sprite);*/
				Diapositivas.Add(new Diapositiva("Monte Everest", "1- 8.848m", "Imagen/everest"));
				Diapositivas.Add(new Diapositiva("K2", "2- 8.611m", "Imagen/k2"));
				Diapositivas.Add(new Diapositiva("Kanchenjunga", "3- 8.586m", "Imagen/kanche"));
				Diapositivas.Add(new Diapositiva("Lhotse", "4- 8.516", "Imagen/lotse"));


		

	}

	void Actualizar(){
		Tittle.text = Diapositivas [actual].titulo;
		Description.text = Diapositivas [actual].descripcion;
		Fotografia.sprite = Diapositivas [actual].fotografia;
	}
	
	// Update is called once per frame
	void Update () {
				
				if(Input.GetKeyDown(KeyCode.LeftArrow)){
			if (actual <= 0)
				actual = Diapositivas.Count - 1;
			else
				actual--;
			Actualizar ();
			
				}else if(Input.GetKeyDown(KeyCode.RightArrow)){
			if (actual >= Diapositivas.Count - 1)
				actual = 0;
			else
				actual++;
			Actualizar (); 

				}
	}
	}

