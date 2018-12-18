using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest01Complete : MonoBehaviour 
{
	public float distance;
	public Text ActionDisplay;
	public Text ActionText;
	public GameObject UIText;
	public GameObject ExtraCursor;

	//When play complete task we want to reactivate this object
	public GameObject ExMark;

	public GameObject ThePlayer;
	public GameObject CompleteTrigger;


	// Update is called once per frame
	void Update () 
	{
		distance = PlayerRCasting.DistanceFromTarget; 
	}

	void OnMouseOver()
	{
		if (distance <= 2 && distance > 0) 
		{
			ActionDisplay.text = "[E]";				
			ActionText.text = "Complete Quest";
			ExtraCursor.SetActive (true);
		
			if (Input.GetButtonDown ("Confirm"))
			{
				ExMark.SetActive(false);
				ActionDisplay.text = string.Empty;				
				ActionText.text = string.Empty;
				ExtraCursor.SetActive (false);
				GlobalEXP.CurrentExp += 100;

			}
		}
		else if (distance <= 0) 
		{
			ActionDisplay.text = string.Empty;				
			ActionText.text = string.Empty;
			ExtraCursor.SetActive (false);
		}
	}

	void OnMouseExit()
	{
		ActionDisplay.text = string.Empty;				
		ActionText.text = string.Empty;
		ExtraCursor.SetActive (false);
	}
	
}
