using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManage : MonoBehaviour 
{
	bool doorIsOpen;
	float doorTimer = 0.0f;
	
	public float doorOpenTime = 10.0f;
	public AudioClip doorOpenSound;
	public AudioClip doorShutSound;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
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
	
}
