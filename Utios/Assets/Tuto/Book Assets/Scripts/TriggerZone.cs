﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZone : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider col) 
	{
		if(col.gameObject.tag == "Player")
		{
			transform.Find("door").GetComponent<DoorManager>().DoorCheck();
		}
	}
}
