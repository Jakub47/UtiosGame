using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollect : MonoBehaviour 
{
	public AudioClip collectSound;

	private float rotateSpeed;


	// Use this for initialization
	void Start () 
	{
		rotateSpeed = 50.0f;	
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		transform.Rotate(new Vector3(0.0f , rotateSpeed * Time.deltaTime,0.0f), Space.World);
	}

	private void OnTriggerEnter(Collider col) 
	{
		if(col.gameObject.tag == "Player")
		{
			AudioSource.PlayClipAtPoint(collectSound,transform.position,1000.0f);
			col.GetComponent<Inventory>().HeathPickUp();
			Destroy(gameObject);
		}
	}
}
