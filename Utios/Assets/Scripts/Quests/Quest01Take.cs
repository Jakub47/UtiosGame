﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest01Take : MonoBehaviour 
{
	public float distance;
	public Text ActionDisplay;
	public Text ActionText;
	public GameObject UIText;
	public GameObject ExtraCursor;

	public GameObject ThePlayer;
	public GameObject noticeCam;

	// Update is called once per frame
	void Update () 
	{
		distance = PlayerRCasting.DistanceFromTarget; 
	}

	void OnMouseOver()
	{
		if (distance <= 2 && distance > 0) 
		{
			AttackBlock.BlockSword = 1;
			ActionDisplay.text = "[E]";				
			ActionText.text = "Open Quest Board";
			ExtraCursor.SetActive (true);
		
			if (Input.GetButtonDown ("Confirm")) {
				//Because we are in menu and we must listen for event of Fire1
				AttackBlock.BlockSword = 2;
				ActionDisplay.text = string.Empty;				
				ActionText.text = string.Empty;
				ExtraCursor.SetActive (false);
				UIText.SetActive (true);
				noticeCam.SetActive (true);
				ThePlayer.SetActive (false);
			}
		}
		else if (distance <= 0) 
		{
			AttackBlock.BlockSword = 0;
			ActionDisplay.text = string.Empty;				
			ActionText.text = string.Empty;
			ExtraCursor.SetActive (false);
		}
	}

	void OnMouseExit()
	{
		AttackBlock.BlockSword = 0;
		ActionDisplay.text = string.Empty;				
		ActionText.text = string.Empty;
		ExtraCursor.SetActive (false);
	}
	
}
