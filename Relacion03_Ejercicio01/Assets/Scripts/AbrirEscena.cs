using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//-----------------------------------
using UnityEngine.SceneManagement;

public class AbrirEscena : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void PulsarBoton(){
		switch (transform.gameObject.tag) {
		case "btn1":
			Abrir ("Escena1");
			break;
		case "btn2":
			Abrir ("Escena2");
			break;
		case "btn3":
			Abrir ("Escena3");
			break;
		case "btn4":
			Abrir ("Escena4");
			break;
		default:
			break;
		}
	}

	void Abrir(string escena){
		SceneManager.LoadScene (escena);
	}
}
