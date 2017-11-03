using UnityEngine;
using System.Collections;

public class Entrada : MonoBehaviour {

	public KeyCode _arriba;
	public KeyCode _abajo;
	public float _velocidad = 0.2F;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (_arriba))
			transform.Translate (0, _velocidad, 0);
		if (Input.GetKey (_abajo))
			transform.Translate (0, -_velocidad, 0);
		if (Input.GetKey (KeyCode.Escape))
			Application.Quit;
	}
}
