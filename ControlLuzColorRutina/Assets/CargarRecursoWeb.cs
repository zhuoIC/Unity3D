using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CargarRecursoWeb : MonoBehaviour {
	public const string URL = "http://iesportada.org/images/Actos/eu_code_week_1cfgm.red.jpg";
	public Image image;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)){
			StartCoroutine("CargarRawImage");
		}

		if(Input.GetKeyDown(KeyCode.Escape)){
			StartCoroutine("CargarUIImage");
		}
	}

	// Corrutina para cargar el recurso
	IEnumerator CargarRawImage(){
		WWW www =  new WWW(URL);
		yield return www; // Espera a que se cargue el recurso
		Texture2D texture = www.texture;
		GetComponent<RawImage>().texture = texture;
	}

	IEnumerator CargarUIImage(){
		WWW www =  new WWW(URL);
		yield return www; // Espera a que se cargue el recurso
		Texture2D texture = www.texture;
		Sprite sprite  = TexturaASprite(texture);
		image.sprite = sprite;
	}

    private Sprite TexturaASprite(Texture2D texture)
    {
		Rect rect = new Rect(0,0,texture.width, texture.height);
		Vector2 pivot = new Vector2(0.5f, 0.5f);
		Sprite sprite = Sprite.Create(texture, rect, pivot);
        return sprite;
    }
}
