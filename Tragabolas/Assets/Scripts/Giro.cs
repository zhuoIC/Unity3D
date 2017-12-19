using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Giro : MonoBehaviour {
	const float GRADOS = 30F;
	Vector3 rotation = new Vector3(GRADOS, GRADOS, GRADOS);
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (rotation * Time.deltaTime);
	}
}
