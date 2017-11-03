using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {
	public Input _tecla;
	public GameObject _objeto;
	public float _min = -4;
	public float _max = 4;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (_objeto.transform.position > _max) {
				
		} else {
			_objeto.transform = transform.Translate ((-1) * Input.GetAxis ("Vertical"), 0, 0);
		}
	}
}
