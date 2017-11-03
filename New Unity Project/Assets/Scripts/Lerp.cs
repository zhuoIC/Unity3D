using UnityEngine;
using System.Collections;

public class Lerp : MonoBehaviour {
	public Vector3 _origen;
	public Vector3 _destino;
	public float _velocidad;
	public GameObject _objeto;

	// Use this for initialization
	void Start () {
		/*_velocidad = 2F;
		_destino = new Vector3 (14, 0, 0);*/
	}
	
	// Update is called once per frame
	void Update () {
		_origen = transform.position;
		_objeto.transform.position = Vector3.MoveTowards (_origen, _destino, _velocidad * Time.deltaTime);
	}
}
