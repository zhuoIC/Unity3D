using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fisica : MonoBehaviour {

	public float _velocidad = 50F;
	public Rigidbody _rigidBody;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		_rigidBody = GetComponent<Rigidbody> ();
	}

	void FixedUpdate () {
		Vector3 fuerzaEmpuje = new Vector3 (Input.GetAxis ("Horizontal") * _velocidad, 0, Input.GetAxis ("Vertical")*_velocidad);
		_rigidBody.AddForce (fuerzaEmpuje);
		_rigidBody.freezeRotation = true;
	}
}
