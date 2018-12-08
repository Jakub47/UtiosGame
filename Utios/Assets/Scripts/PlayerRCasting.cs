using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerRCasting : MonoBehaviour 
{
	public GameObject ActionDisplay;
	public GameObject ActionText;
	public GameObject ExtraCursor;

	void Update () 
	{
		RaycastHit hit;
		if(Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward),
						 out hit , 3f))
		{		
			if(hit.collider.gameObject.tag == "playerDoor")
			{
				ActionDisplay.SetActive(true);
				ActionText.SetActive(true);
				ExtraCursor.SetActive(true);
				if(Input.GetButtonDown("Confirm"))
					hit.collider.gameObject.GetComponent<DoorManage>().DoorCheck();
			}
			else
			{
				ActionDisplay.SetActive(false);
				ActionText.SetActive(false);
				ExtraCursor.SetActive(false);
				
			}
		}
	}
}
