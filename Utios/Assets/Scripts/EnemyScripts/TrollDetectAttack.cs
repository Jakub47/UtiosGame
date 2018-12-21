using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrollDetectAttack : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}



	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player") 
		{
			other.gameObject.GetComponent<Inventory>().SendMessage("TakeDamage");
			Debug.Log("Took damage!");
		}
	}
}
