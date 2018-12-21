using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NPC001 : MonoBehaviour 
{
	public float distance;
	public Text ActionDisplay;
	public Text ActionText;
	public GameObject ExtraCursor;
	public GameObject ThePlayer;
	public GameObject TextBox;
	public Text NPCName;
	public Text NPCText;

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
			ActionText.text = "Talk";
			ExtraCursor.SetActive (true);
			
			if (Input.GetButtonDown ("Confirm")) {
				//Because we are in menu and we must listen for event of Fire1
				AttackBlock.BlockSword = 2;
				ActionDisplay.text = string.Empty;				
				ActionText.text = string.Empty;
				ExtraCursor.SetActive (false);
				//ThePlayer.SetActive (false);
				StartCoroutine(NPC001Active());
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

	IEnumerator NPC001Active()
	{
		TextBox.SetActive (true);
		NPCName.text = "warrior";
		NPCName.gameObject.SetActive (true);
		NPCText.text = "Hello friend, I may have quest for you, if you wish to accept it. Please come back o this afternoon";
		NPCText.gameObject.SetActive (true);
		yield return new WaitForSeconds(5.5f);
		NPCName.gameObject.SetActive (false);
		NPCText.gameObject.SetActive (false);
		TextBox.SetActive (false);
		ActionDisplay.text = "[E]";				
		ActionText.text = "Talk";
		 
	}
}
