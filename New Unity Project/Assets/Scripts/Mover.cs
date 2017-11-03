using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {
	public float velocidad = 0.33F;
	float _valorZoom = 1F;
	float _tamanoZoom = 0.5F;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (velocidad * Input.GetAxis ("Horizontal"), 0, 0);
		transform.Translate (0, 0, velocidad * Input.GetAxis ("Vertical"));
		if (Input.GetAxis ("Fire1") != 0) {
			// Hacer algo
			Debug.Log ("Disparando...");
		}
		// Control del zoom
		/*_valorZoom = Input.GetAxis("Zoom");
		transform.localScale += new Vector3 (_valorZoom * _tamanoZoom * Time.deltaTime,
			_valorZoom * _tamanoZoom * Time.deltaTime,
			_valorZoom * _tamanoZoom * Time.deltaTime);*/
	}
}
