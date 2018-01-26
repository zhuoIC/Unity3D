using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverTexto : MonoBehaviour {

	Vector3 pos;
	Vector3 movimiento;
	float velocidadScroll;

	// Use this for initialization
	void Start () {
		velocidadScroll = 2f;
	}
	
	// Update is called once per frame
	void Update () {
		pos = transform.position;
		movimiento = transform.TransformDirection(Vector3.up);
		pos += movimiento * velocidadScroll * Time.deltaTime;
		transform.position = pos;
	}
}
