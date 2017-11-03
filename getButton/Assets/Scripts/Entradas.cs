using UnityEngine;
using System.Collections;

public class Entradas : MonoBehaviour {

	float _esperar = 0F;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// Basados en el InputManager
		if(Input.GetButton("Jump")){
			Debug.Log("JUMP");
		}
		if(Input.GetButtonDown("Fire1")){
			Debug.Log ("Down");
		}

		// De tipo string Tecla
		if(Input.GetKey("a")){
			Debug.Log ("a");
		}
		// No admite mayúsculas
		/*if(Input.GetKey("S")){
			Debug.Log ("S");
		}*/

		if(Input.GetKey(KeyCode.E) && Time.time > _esperar){
			Debug.Log ("e");
			_esperar = Time.time + 2F; // 2 segundos
		}

		if(Input.GetMouseButtonDown(0))
			Debug.Log("Boton Izq Raton");
		if(Input.GetKey(KeyCode.Mouse1))
			Debug.Log("Boton Der Raton");
	}
}
