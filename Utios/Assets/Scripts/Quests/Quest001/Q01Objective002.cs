using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Q01Objective002 : MonoBehaviour 
{
	public float TheDistance;
	public GameObject TreasureChest;
	public GameObject ActionDisplay;
	public GameObject ActionText;
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
				TheObjective.transform.localScale -= new Vector3(0.0f,0.1f,0.0f);
			}
		}
	}


	void OnMouseOver()
	{
		if (TheDistance <= 2) 
		{
			ActionText.GetComponent<Text>().text = "Open chest!";
			ActionText.SetActive(true);
			ActionDisplay.SetActive(true);
		}

		if (Input.GetButtonDown ("Confirm")) 
		{
			if(TheDistance <= 2)
			{
				this.GetComponent<BoxCollider>().enabled = false;
				TreasureChest.GetComponent<Animation>().Play("ChestOpen");
				ClosedObjective = 3;
				ActionText.SetActive(false);
				ActionDisplay.SetActive(false);
			}
		}
	}

	void OnMouseExit()
	{
		ActionDisplay.SetActive (false);
		ActionText.SetActive (false);
	}
}
