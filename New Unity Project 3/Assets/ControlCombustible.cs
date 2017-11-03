using UnityEngine;
using System.Collections;
//-------------------------
using UnityEngine.UI;

public class ControlCombustible : MonoBehaviour {

	float _incremento = 10F;
	Slider _slider;
	static public bool _hayCombustible = true;

	void Start () {
		_slider = GetComponent<Slider>();
	}
	
	void Update () {
		if (Input.GetKeyUp(KeyCode.A)) {
			_slider.value += _incremento;
			_hayCombustible = true;
		}

		if (Input.GetKeyDown(KeyCode.Z)) {
			_slider.value -= _incremento;
		}

		if (_slider.value <= 0) {
			_hayCombustible = false;
		}
	}
}
