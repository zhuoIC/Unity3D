using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour {

	Texture _texturaObjeto;
	// Use this for initialization
	void Start () {
		_texturaObjeto = GetComponent<Texture>();
	}

	public void Detectado(){
		GetComponent<Renderer>().material.color = Color.black;
	}

	public void NoDetectado(){
		GetComponent<Renderer>().material.color = Color.red;
	}
}
