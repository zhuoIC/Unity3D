using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorJugador : MonoBehaviour {

	Rigidbody rb;
	public float velocidad = 5f;
	// Para la puntuación
	int contador;
	public Text puntuacion;
	public Text fin;
	public GameObject items;

	void Awake () {
		rb = GetComponent<Rigidbody> ();	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float movimientoH = Input.GetAxis ("Horizontal");
		float movimientoV = Input.GetAxis ("Vertical");
		Vector3 movimiento = new Vector3 (movimientoH, 0, movimientoV);
		rb.AddForce (movimiento * velocidad);
		if (items.transform.childCount == 0) {
			rb.isKinematic = true;
			fin.text = "¡Fin del juego!";
		}
	}

	void OnTriggerEnter(Collider other){
		Destroy (other.gameObject);
		puntuacion.text = "Puntuación: " + ++contador;
	}
}
