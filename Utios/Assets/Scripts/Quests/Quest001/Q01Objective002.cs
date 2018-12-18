﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Q01Objective002 : MonoBehaviour 
{
	public float TheDistance;
	public GameObject TreasureChest;
	public Text ActionDisplay;
	public Text ActionText;
	public GameObject ExtraCursor;
	public GameObject TakeSword;

	public GameObject TheObjective;
	public int ClosedObjective;

	void Update () 
	{
		TheDistance = PlayerRCasting.DistanceFromTarget;
		if (ClosedObjective == 3) 
		{
			if(TheObjective.transform.localScale.y <= 0.0f)
			{
				ClosedObjective = 0;
				TheObjective.SetActive(false);
			}
			else
			{
				TheObjective.transform.localScale -= new Vector3(0.0f,0.01f,0.0f);
			}
		}
	}


	void OnMouseOver()
	{
		if (TheDistance <= 2 && TheDistance > 0) 
		{
			ActionDisplay.text = "[E]";				
			ActionText.text = "Open Quest Board";
			ExtraCursor.SetActive (true);
		}

		if (Input.GetButtonDown ("Confirm")) 
		{
			if(TheDistance <= 2 && TheDistance > 0)
			{
				this.GetComponent<BoxCollider>().enabled = false;
				TreasureChest.GetComponent<Animation>().Play("ChestOpen");
				TakeSword.SetActive(true);
				ClosedObjective = 3;
				ActionDisplay.text = "";				
				ActionText.text = "";
				ExtraCursor.SetActive(false);
			}
		}
	}

	void OnMouseExit()
	{
		ActionDisplay.text = "";				
		ActionText.text = "";
		ExtraCursor.SetActive(false);
	}

}
