using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlGUI : MonoBehaviour {
	bool estaMostrando = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)){
			estaMostrando = !estaMostrando;
		}
	}

	void OnGUI()
	{
		if(estaMostrando){
			MostrarLabel();
		}
		//MostrarBoton();
		MostrarRepiteBoton();
	}

	void MostrarLabel(){
		string textoMostrado = "Soy el texto de ejemplo";
		int anchoCaracter = 6;
		float x = Screen.width/2 - textoMostrado.Length * anchoCaracter/2;
		float y = 50;
		float ancho = 300;
		float alto = 20;
		Rect _rect = new Rect(x,y,ancho,alto);
		GUI.color = Color.red;
		GUI.Label(_rect, "Soy un label");
	}

	void MostrarBoton(){
		GUI.Button(new Rect(10,10,300,30), new GUIContent("Púlsame", "Contenido Tooltip"));
		GUI.Label(new Rect(10,40,300,40), GUI.tooltip);
	}

	void MostrarRepiteBoton(){
		if(GUI.RepeatButton(new Rect(20,10,200,30), "Repite")){
			estaMostrando = true;
		}
		else{
			//estaMostrando = false;
		}
	}
}
