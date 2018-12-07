using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour 
{
	bool doorIsOpen;
	float doorTimer = 0.0f;
	
	public float doorOpenTime = 3.0f;
	public AudioClip doorOpenSound;
	public AudioClip doorShutSound;
	
	void Start () 
	{
		doorTimer = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		
		//Time.deltTime == real time has passd!
		if(doorIsOpen)
		{
			doorTimer += Time.deltaTime;
		}
		
		if (doorTimer >= doorOpenTime) 
		{
			Door(doorShutSound , false , "doorshut");
			doorTimer = 0.0f;
		}
	}

	//Just for checking if dorr is currently ooen!
	public void DoorCheck()
	{
		if (!doorIsOpen) {
			Door (doorOpenSound, true , "dooropen");
		}
	}

	void Door(AudioClip aClip, bool OpenCheck, string animName  )
	{
		gameObject.GetComponent<AudioSource> ().PlayOneShot (aClip);
		doorIsOpen = OpenCheck;
		transform.parent.GetComponent<Animation> ().Play (animName);
	}

}
