using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tt : MonoBehaviour 
{

	// Update is called once per frame
	void Update () 
	{
		if (gameObject.activeSelf) 
		{
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
		}
	}
}
