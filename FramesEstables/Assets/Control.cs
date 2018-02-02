using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour {

	// Mover objeto dentro de unos valores
	Vector3 posIniObj;
	Vector3 posActObj;
	float posXact;
	float posYact;
	float posZact;
	float velocidad = 0.05F;
	float minimoX = -4.5F;
	float maximoX = 4.5F;
	float minimoZ = -4.5F;
	float maximoZ = 4.5F;
	float velocidadRotacion = 2.5F;

	//Capturas
	string carpeta = "Capturas";
	int frameRate = 25;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(new Vector3(velocidadRotacion, velocidadRotacion, velocidadRotacion));
		MoverCubo();
		//Cambiar el TimeSacle al valro 0 con la tecla de espacio, 1 con la A
		if(Input.GetKey(KeyCode.Space)){
			Time.timeScale = 0; // Si se pone a 0 no entra más en el FixedUpdate
		}
		if(Input.GetKey(KeyCode.P)){
			Time.timeScale = 1;
		}
		// Guardar capturas
		string nombre = string.Format("{0}/{1:D04} captura.png", carpeta, Time.frameCount);
		Application.CaptureScreenshot(nombre);

	}

	/// <summary>
	/// OnGUI is called for rendering and handling GUI events.
	/// This function can be called multiple times per frame (one call per event).
	/// </summary>
	void OnGUI()
	{
		GUI.Label(new Rect(10,10,200,30), "TimeScale: " + Time.timeScale);
	}

	void MoverCubo(){
		// Coordenada X
		posXact = transform.position.x + (Input.GetAxis("Horizontal")*velocidad);
		//posActObj = new Vector3(Mathf.Clamp(posXact, minimoX, maximoX), transform.position.y, transform.position.z);
		// Coordenada Z
		posZact = transform.position.z + (Input.GetAxis("Vertical")*velocidad);
		posActObj = new Vector3(Mathf.Clamp(posXact, minimoX, maximoX), transform.position.y,
		Mathf.Clamp(posZact, minimoZ, minimoX));
		transform.position = posActObj;
	}
}
