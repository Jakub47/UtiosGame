using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InflictDamage : MonoBehaviour 
{
	//Amount of damage we can deal 
	public int DamagaeAmount = 5;
	//how far enemy is from us
	public float TargetDistance;
	public float AllowedRange = 2.7f;


	void Update () 
	{
		if (Input.GetButtonDown ("Fire1")) 
		{
			RaycastHit hit;
			if(Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward),out hit))
			{
				TargetDistance = hit.distance;
				if(TargetDistance <= AllowedRange)
				{
					hit.transform.SendMessage("DeductPoints", DamagaeAmount, SendMessageOptions.DontRequireReceiver);
				}
			}
		}
	}
}
