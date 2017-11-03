using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnadirBotones : MonoBehaviour {

	GameObject _primerBoton;	// Botón a clonar
	GameObject _padreDeLosBotones; // Contenido

	// Use this for initialization
	void Start () {
		_primerBoton = GameObject.Find ("btnPrimero");
		_padreDeLosBotones = GameObject.Find ("Contenido");
	}

	// Update is called once per frame
	void Update () {


	}

	public void AnadirBoton(){
		// Añado un clon del botón btnPrimero como hijo del GameObject Contenido
		Instantiate(_primerBoton, _padreDeLosBotones.GetComponent<Transform>());
	}
}
