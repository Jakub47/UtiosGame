using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour 
{
	GameObject currentDoor;

	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		RaycastHit ray;
		if(Physics.Raycast(transform.position , transform.forward , out ray , 3))
		{
			if(ray.collider.gameObject.tag == "playerDoor")
			{
				currentDoor = ray.collider.gameObject;
				currentDoor.SendMessage("DoorCheck");
			}
		}

	}

}
	
