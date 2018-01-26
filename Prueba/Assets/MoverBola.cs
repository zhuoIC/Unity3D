using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverBola : MonoBehaviour {

	float _velocidad = 5f;
	float valorSalto = 2f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Jump") && Mathf.Abs(GetComponent<Rigidbody>().velocity.y) < 0.01f) {
			GetComponent<Rigidbody>().AddForce (Vector3.up * valorSalto, ForceMode.Impulse);
		}
	}

	void FixedUpdate()
	{
				Vector3 fuerzaEmpuje = new Vector3 (
			Input.GetAxis("Horizontal") * _velocidad,
			0,
			Input.GetAxis("Vertical") * _velocidad);
			GetComponent<Rigidbody>().AddForce (fuerzaEmpuje);
	}
}
