using UnityEngine;
using System.Collections;

public class Rotando : MonoBehaviour {

	public float x = 2;
	public float y = 2;
	public float z = 2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (x, y, z);
	}
}
