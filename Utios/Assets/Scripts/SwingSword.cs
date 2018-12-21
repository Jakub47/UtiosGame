using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingSword : MonoBehaviour
{
	public GameObject TheSword;
	public int SwordStatus;
	public AudioClip SwingSound;

	GameObject Player;

	void Start()
	{
		Player = GameObject.FindGameObjectWithTag ("Player");
	}

	void Update () 
	{
		if (Input.GetButtonDown ("Fire1") && SwordStatus == 0 && AttackBlock.BlockSword == 0 && Inventory.stamina > 0) 
		{
			Player.GetComponent<Inventory>().SendMessage("SomeAction");
			StartCoroutine(SwingSwordFunction());
		}
	}

	IEnumerator SwingSwordFunction()
	{
		SwordStatus = 1;
		TheSword.GetComponent<Animation> ().Play ("Sword01Anim");
		gameObject.GetComponent<AudioSource> ().PlayOneShot (SwingSound);
		SwordStatus = 2;

		//Wait a couple of seconds for animation to Stop
		yield return new WaitForSeconds (1.0f);
		SwordStatus = 0;
	}
}
