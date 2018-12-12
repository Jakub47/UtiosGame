using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Q01Objective001 : MonoBehaviour 
{
	public GameObject TheObjective;
	public int ClosedObjective;


	// Update is called once per frame
	void Update () 
	{
		if (ClosedObjective == 1) {
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

	void OnTriggerEnter(Collider col)
	{

		StartCoroutine (FinishObjective());
	}

	IEnumerator FinishObjective()
	{
		Debug.Log ("DAS");
		TheObjective.SetActive (true);
		yield return new WaitForSeconds(1f);
		ClosedObjective = 1;
	}
}
