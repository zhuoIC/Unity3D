using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Version_5_PararCorrutinas : MonoBehaviour {

	bool activo = true;
	const int NCUBOS = 3;
	GameObject[] cubos = new GameObject[NCUBOS];
	float destinoX =4;
	Vector3 velocidad = new Vector3(0.05f,0,0);
	Vector3 velocidadRotacion = new Vector3(0,0,5f);

	void Start () {
		//StartCoroutine("SaludarCadaSegundo");
	}

	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)){
			StopCoroutine("SaludarCadaSegundo");
		}
		if(Input.GetKeyDown(KeyCode.S)){
			activo = false;
		}
	}

	IEnumerator SaludarCadaSegundo(string mensaje, float tiempo){
		int nSaludo = 0;
		while (true)
		{
			if(! activo){
				yield break;
			}
			Debug.Log(mensaje +" "+ ++nSaludo);
			yield return new WaitForSeconds(tiempo);
		}
	}

	void OnDisable()
	{
		StopAllCoroutines();
	}

	private void OnEnable() {
		StartCoroutine(SaludarCadaSegundo("Hola a todos", 1));
		StartCoroutine(SaludarCadaSegundo("Hola a casi todos", 3));
		StartCoroutine(SaludarCadaSegundo("Hola Eliseo", 0.25f));
	}
}
