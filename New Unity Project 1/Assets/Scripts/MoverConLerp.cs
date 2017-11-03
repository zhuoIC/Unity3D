using UnityEngine;
using System.Collections;

public class MoverConLerp : MonoBehaviour {
	public float _minimo = -3F;
	public float _maximo = 3F;
	float t = 0.0F;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(Mathf.Lerp(_minimo, _maximo, t), 0, 0);
		t += 0.5F * Time.deltaTime;
		if(t> 1.0F){
			float tmp = _maximo;
			_maximo = _minimo;
			_minimo = tmp;
			t = 0.0F;
		}
	}
}
