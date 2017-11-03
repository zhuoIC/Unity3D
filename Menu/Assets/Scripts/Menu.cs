using UnityEngine;
using System.Collections;
//-----------------------------
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	public void Jugar (string nombreNivel)
	{
		SceneManager.LoadScene (nombreNivel);
	}

	public void Salir()
	{
		Application.Quit();
	}
}
