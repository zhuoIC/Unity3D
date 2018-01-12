using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlRaton : MonoBehaviour {
	public Text _textoMostrado;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// Eventos del teclado
	public void OnMouseEnter(){
		GetComponent<Renderer> ().material.color = Color.red;
		_textoMostrado.text = "OnMouseEnter... Red";
	}

	public void OnMouseDown(){
		_textoMostrado.text = "OnMouseDown...";
	}

	public void OnMouseExit(){
		GetComponent<Renderer> ().material.color = Color.blue;
		_textoMostrado.text = "OnMouseExit... Blue";
	}

	public void OnMouseOver(){
	}

	void OnMouseUp()
	{
		_textoMostrado.text = "OnMouseUp...";
	}
}
