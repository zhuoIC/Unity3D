using UnityEngine;
using System.Collections;
//--------------------------
using UnityEngine.SceneManagement;

public class EscenaJuego : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			SceneManager.LoadScene ("Principal");
		}
	}
}
