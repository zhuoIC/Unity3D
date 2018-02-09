﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Version_4_UsandoCorrutinas : MonoBehaviour {

	const int NCUBOS = 3;
	GameObject[] cubos = new GameObject[NCUBOS];
	float destinoX =4;
	Vector3 velocidad = new Vector3(0.05f,0,0);
	Vector3 velocidadRotacion = new Vector3(0,0,5f);

	void Start () {
		LocateCubes ();
		StartCoroutine("MoverCubos");
	}

	void Update () {
	}
	void LocateCubes()
	{
		cubos [0] = GameObject.Find ("Cube1");
		cubos [1] = GameObject.Find ("Cube2");
		cubos [2] = GameObject.Find ("Cube3");
	}

	IEnumerator MoverCubos(){
		foreach (GameObject cuboTmp in cubos)
		{
			// Mueve el cubo hasta el destino
			yield return StartCoroutine(MoverCubo(cuboTmp));

			/*for (float tiempoBucle = Time.time; Time.time - tiempoBucle < 3;){
				yield return null;
			}*/

			yield return new WaitForSeconds(3);

			cuboTmp.GetComponent<MeshRenderer>().material.color = Color.magenta;

			yield return StartCoroutine(Rotarcubos(cuboTmp));

			cuboTmp.GetComponent<MeshRenderer>().material.color = Color.black;

		}
	}

	IEnumerator MoverCubo(GameObject cuboTmp){
			while (cuboTmp.GetComponent<Transform>().position.x < destinoX)
			{
				cuboTmp.GetComponent<Transform>().Translate(velocidad.x, velocidad.y, velocidad.z * Time.deltaTime);
				yield return null;
			}
	}

	IEnumerator Rotarcubos(GameObject cuboTmp){
			// Rota cada cubo al llegar al destino
			while (cuboTmp.GetComponent<Transform>().rotation.eulerAngles.z < 90)
			{
				Vector3 anguloActual = cuboTmp.transform.rotation.eulerAngles;
				cuboTmp.GetComponent<Transform>().rotation = Quaternion.Euler(anguloActual + velocidadRotacion);
				yield return null;
			}
	}
}
