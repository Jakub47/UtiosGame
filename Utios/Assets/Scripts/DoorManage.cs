using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorManage : MonoBehaviour 
{
	bool doorIsOpen;
	float doorTimer = 0.0f;
	public float distance;


	public Text ActionDisplay;
	public Text ActionText;
	public GameObject ExtraCursor;

	public float doorOpenTime = 10.0f;
	public AudioClip doorOpenSound;
	public AudioClip doorShutSound;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		distance = PlayerRCasting.DistanceFromTarget; 

		if(doorIsOpen)
		{
			doorTimer += Time.deltaTime;
		}
		
		if (doorTimer >= doorOpenTime) 
		{
			Door(doorShutSound , false , "CloseDoor");
			doorTimer = 0.0f;
		}
	}

	public void DoorCheck()
	{
		if (!doorIsOpen) 
			Door (doorOpenSound, true , "OpenDoor");
		else if(doorIsOpen)
		{
			if (!transform.GetComponent<Animation> ().IsPlaying("OpenDoor"))
			{
			Door(doorShutSound , false , "CloseDoor");
			doorTimer = 0.0f;
			}		
		}
	}

	void Door(AudioClip aClip, bool OpenCheck, string animName  )
	{
		gameObject.GetComponent<AudioSource> ().PlayOneShot (aClip);
		doorIsOpen = OpenCheck;
		transform.GetComponent<Animation> ().Play (animName);
	}

	void OnMouseOver()
	{
		if (distance <= 2 && distance > 0) 
		{
			ActionDisplay.text = "[E]";				
			ActionText.text = "Open Door";
			ExtraCursor.SetActive(true);
			
			if (Input.GetButtonDown ("Confirm")) 
			{
				ActionDisplay.text = string.Empty;				
				ActionText.text = string.Empty;
				ExtraCursor.SetActive (false);
				DoorCheck();
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
