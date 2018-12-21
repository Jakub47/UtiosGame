using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene01Skin : MonoBehaviour {

	public GameObject FadeIn;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		StartCoroutine (FadeQuit());	
	}

	IEnumerator FadeQuit()
	{
		yield return new WaitForSeconds (1);
		FadeIn.SetActive (false);
	}
}
