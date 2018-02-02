using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Asignado al GO 1
public class EnviarMensaje : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// Lanzar mensaje
		if(Input.GetKeyDown(KeyCode.Space)){
			GameObject.FindGameObjectWithTag("ObjetoReceptor").SendMessage("MostrarDatos");
		}
	}
}
