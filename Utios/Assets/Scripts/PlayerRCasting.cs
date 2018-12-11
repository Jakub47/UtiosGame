using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerRCasting : MonoBehaviour 
{
	//Testing
	public static float DistanceFromTarget;
	public float toTarget;

	public Text ActionDisplay;
	public Text ActionText;
	public GameObject ExtraCursor;

	void Update () 
	{
		DistanceFromTarget = toTarget;
		RaycastHit hit;
		if (Physics.Raycast (transform.position, transform.TransformDirection (Vector3.forward),
						 out hit, 3f)) {		
			toTarget = hit.distance;
		} else 
		{
			toTarget = 0;
		}
	}
}
