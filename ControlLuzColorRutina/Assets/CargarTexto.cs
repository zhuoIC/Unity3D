using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CargarTexto : MonoBehaviour {

	public const string URL = "http://www.ascii-art.de/ascii/ab/android.txt";
	// Use this for initialization
	void Start () {
		StartCoroutine("CargarText");
	}

	// Update is called once per frame
	void Update () {

	}

	IEnumerator CargarText(){
		Text textUI = GetComponent<Text>();
		textUI.text = "Cargando el fichero...";
		WWW www = new WWW(URL);
		yield return www;
		textUI.text = www.text;
	}
}
