using UnityEngine;
using System.Collections;
//----------------------------
using UnityEngine.UI;

public class UIControlRotacion : MonoBehaviour {

	Transform _cubo;
	public float x = 50F;
	public float y = 100F;
	public float z = 100F;
	public float w = -50F;
	public bool _sigueAlCubo = false; // Sincroniza la rotación con el cubo

	// Use this for initialization
	void Start () {
		_cubo = GameObject.Find ("Cube").GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (!_sigueAlCubo)
			transform.rotation = new Quaternion (x, y, z, w);
		if (ControlCombustible._hayCombustible) {
			_cubo.transform.Rotate (Vector3.up);

		}
	}
}
