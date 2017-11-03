using UnityEngine;
using System.Collections;

public class MoverPinPong : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(Mathf.PingPong(Time.time * 10F, 10), 0, 0);
	}
}
