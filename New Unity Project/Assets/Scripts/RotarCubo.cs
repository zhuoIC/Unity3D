using UnityEngine;
using System.Collections;

public class RotarCubo : MonoBehaviour {

	public float x = 2;
	public float y = 2;
	public float z = 0;
	public float w = 0;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		transform.rotation = new Quaternion (x, y, z, w);
	}
}
