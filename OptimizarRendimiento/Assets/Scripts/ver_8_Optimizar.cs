using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ver_8_Optimizar : MonoBehaviour {
	GameObject[] _enemigos; // Lista de enemigos
	// Use this for initialization
	void Start () {
		_enemigos = GameObject.FindGameObjectsWithTag("Enemigo");
	}
	
	// Update is called once per frame
	void Update () {
		ComrprobarProxEnemigo();
	}

	// Comrprobar la proximidad de cualquier enemigo
	void ComrprobarProxEnemigo(){
		float maxDistPermitida = 1.5f;
		foreach (GameObject enemigo in _enemigos)
		{
			if(Vector3.Distance(transform.position, enemigo.transform.position) < maxDistPermitida){
				Debug.Log("Detectado");
				enemigo.GetComponent<Enemigo>().Detectado();
			}
			else
				enemigo.SendMessage("NoDetectado");

		}
	}
}
