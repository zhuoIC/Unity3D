using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ver_7_Efectos : MonoBehaviour {
	public Light luz;

	public void iniParpadeo(){
		StartCoroutine("Parpadeo");
	}
	public void finParpadeo(){
		StopCoroutine("Parpadeo");
	}
	public void iniColor(){
		StartCoroutine("ControlColor");
	}
	public void finColor(){
		StopCoroutine("ControlColor");
	}


	IEnumerator Parpadeo(){
		int nveces = 20;
		while (true)
		{
			for (int i = 0; i < nveces; i++)
			{
				luz.enabled = !luz.enabled;
				yield return new WaitForSeconds(Random.Range(0.1f,0.5f));
			}
			luz.enabled = Random.Range(0,2) == 0;
			yield return new WaitForSeconds(3);
		}
	}
	IEnumerator ControlColor(){
		while (true)
		{
			luz.color = Color.Lerp(Color.blue, Color.red, Mathf.PingPong(Time.time / 2, 1));
			yield return null;
		}
	}
}
