using UnityEngine;
using System.Collections;
using System.Collections.Generic;
//------------------------------------------------
using UnityEngine.UI;

public class Contador : MonoBehaviour {
	GameObject _texto;
	Text _contenido;
	float _tiempo = 0.0F;

	// Use this for initialization
	void Start () {
		_texto = GameObject.Find ("TextoContador");
		_contenido = _texto.GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		_tiempo += Time.deltaTime;
		_contenido.text = _tiempo.ToString ("0000");
	}
}
