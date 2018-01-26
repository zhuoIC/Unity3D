using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador : MonoBehaviour {

	int btnClickeado = 0;
	string[] listaDeBotones = { "Uno", "Dos", "Tres"};
	string contenido = "Modifícame...";
	public GUIStyle personalizaBtn;
	public GUISkin controladorSkin;

	private void OnGUI() {
		contenido = GUI.TextField(new Rect(10,100,300,30), contenido, 30);
		CambiarAspecto();
		if(GUI.changed){
			Debug.Log("El contenido ha cambiado.");
		}

		/* Detectar el botón pulsado
		btnClickeado = GUI.Toolbar(new Rect(10,10,120,75), btnClickeado, listaDeBotones);

		if(GUI.changed){
			Debug.Log("Has hecho click en el Toolbar.");
			switch(btnClickeado){
				case 0:
					Debug.Log("Primer botón.");
					break;
				case 1:
					Debug.Log("Segundo botón.");
					break;
				case 2:
					Debug.Log("Tercer botón.");
					break;
			}
		}*/
	}

	void CambiarAspecto(){
		//GUI.Label(new Rect(10,150,100,50), "Soy un label camuflado a caja", "box");
		GUI.Label(new Rect(120,150,100,50), "Soy el boton camuflado a toogle", personalizaBtn);

	}

	void CambiarSkin(){
		GUI.skin = controladorSkin;
		GUI.Label(new Rect(120,150,100,50), "Soy el botón.");
		GUI.skin = null;
		GUI.Label(new Rect(120,20,100,50), "Soy el botón sin estilo.");

	}
}
