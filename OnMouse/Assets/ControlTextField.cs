using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlTextField : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	string textIni = "Escribe algo...";
	void OnGUI(){
		textIni = GUI.TextField(new Rect(10,40,300,30), textIni);
		MostrarLabel(textIni);
	}

	void MostrarLabel(string texto){
		int anchoCaracter = 6;
		float x = Screen.width/2 - texto.Length * anchoCaracter/2;
		float y = 50;
		float ancho = 300;
		float alto = 20;
		Rect _rect = new Rect(x,y,ancho,alto);
		GUI.color = Color.red;
		GUI.Label(_rect, texto);
	}
}
