using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TroolBossAI : MonoBehaviour
{

	public GameObject TheDestination;
	NavMeshAgent TheAgent;

	// Use this for initialization
	void Start ()
	{
		TheAgent = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		TheAgent.SetDestination (TheDestination.transform.position);	
	}
}
