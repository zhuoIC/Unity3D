using UnityEngine;
using System.Collections;
//------------------------
using UnityEngine.UI;

public class Eventos : MonoBehaviour {

	GameObject _intLuz;
	GameObject _toogle;

	void Start () {
		// Referencia a la luz de la escena por su TAG
		_intLuz = GameObject.FindWithTag ("intLuz");
		_toogle = GameObject.Find ("Toggle");
	}
	
	// Update is called once per frame
	void Update () {
		InterruptorLuz ();
	}

	public void InterruptorLuz()
	{
		_intLuz.SetActive (_toogle.GetComponent<Toggle> ().isOn);
	}
}
