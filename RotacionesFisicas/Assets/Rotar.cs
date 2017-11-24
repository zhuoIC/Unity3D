using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotar : MonoBehaviour {
	private float grados = 150;
	public Transform objetivo;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey(KeyCode.A)) {
			Invoke ("RotarEnY", 0.5F);
		}
		if (Input.GetKeyDown ("m")) {
			MirarAlObjetivo ();
		}
	}

	void RotarEnY(){
		// Rota instantáneamente a la posición indicada
		GetComponent<Rigidbody> ().rotation = Quaternion.Euler (new Vector3(0, grados++, 0));
	}

	void MirarAlObjetivo()
	{
		/**
		 * Obtener la posición relativa de este objeto con respecto
		 * al que va a mirar, se consigue restando ambas posiciones
		 */
		Vector3 posicionRelativa = objetivo.position - transform.position;

		// Obtener el quaternion para aplicar la rotación
		Quaternion rotation = Quaternion.LookRotation(posicionRelativa);

		// Aplicar la rotación
		transform.rotation = rotation;
	}
}
