using UnityEngine;
using System.Collections;

public class Ejemplo : MonoBehaviour {

	public int _limiteMenor = -10;
	public int _limiteMayor = 10;
	public float _velocidad = 1F;
	float _valor = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		_valor += Input.GetAxis ("Horizontal") * _velocidad;
		_valor = Mathf.Clamp (_valor, _limiteMenor, _limiteMayor);
		transform.position = new Vector3 (_valor, 0, 0);
	}
}
