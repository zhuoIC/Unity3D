using UnityEngine;
using System.Collections;

public class RotationLErp : MonoBehaviour {
	public float _velociadd = 2F;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis ("Jump") != 0) {
			transform.rotation = Quaternion.Lerp (transform.rotation,
				Quaternion.Euler (0, 90, 0),
				Time.deltaTime * _velociadd);
		}
	}
}
