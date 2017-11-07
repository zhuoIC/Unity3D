using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Asignada al objeto a controlar
public class ControladorObjeto : MonoBehaviour {

	float velocidad = 5.0F;	// velocidad del desplazamiento en x, y
	float veloZoom = 0.05F;	// Para hacer zoom

	// Valores para la accion realizada
	bool derecha = false;
	bool izquierda = false;
	bool arriba = false;
	bool abajo = false;
	bool aumentar = false;
	bool disminuir = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (derecha)
			transform.Translate (Vector3.right * Time.deltaTime * velocidad);
		if (izquierda)
			transform.Translate (Vector3.left * Time.deltaTime * velocidad);
		if (arriba)
			transform.Translate (Vector3.up * Time.deltaTime * velocidad);
		if (abajo)
			transform.Translate (Vector3.down * Time.deltaTime * velocidad);
		if (aumentar) {
			transform.localScale = new Vector3 (transform.localScale.x + veloZoom, transform.localScale.y + veloZoom, transform.localScale.z + veloZoom);
		}
		if (disminuir) {
			transform.localScale = new Vector3 (transform.localScale.x - veloZoom, transform.localScale.y - veloZoom, transform.localScale.z - veloZoom);
		}
	}

	public void MoverDerecha()
	{
		derecha = true;
	}
	public void MoverIzquierda()
	{
		izquierda = true;
	}
	public void MoverArriba()
	{
		arriba = true;
	}
	public void MoverAbajo()
	{
		abajo = true;
	}
	public void AumentarEscala()
	{
		aumentar = true;
	}
	public void DismunuirEscala()
	{
		disminuir = true;
	}
	public void Detener(){
		derecha = false;
		izquierda = false;
		arriba = false;
		abajo = false;
		aumentar = false;
		disminuir = false;
	}
}
