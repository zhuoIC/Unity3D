using UnityEngine;
using System.Collections;

public class RotarLerp : MonoBehaviour {

	public Transform _desde;
	public Transform _a;
	public float _velocidad = 3F;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.rotation = Quaternion.Lerp (_desde.rotation, _a.rotation, Time.deltaTime * _velocidad);
		transform.eulerAngles = new Vector3 (43,75,59);
		transform.Rotate (new Vector3 (2, 6, 6), Space.Self);
	}
}
