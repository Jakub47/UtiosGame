using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonEnemy : MonoBehaviour
{
	public int EnemyHealth = 10;
	public Animator anim;

	void DeductPoints(int DamageAmount)
	{
		EnemyHealth -= DamageAmount;
	}

	//If the enemy health is 0 destroy
	void Update () 
	{
		if (EnemyHealth <= 0) 
		{
			StartCoroutine(DeathSkeleton());
			anim.gameObject.GetComponent<chase>().Dead();

		}
	}

	IEnumerator DeathSkeleton()
	{
		GlobalEXP.CurrentExp += 10;
		anim.SetBool ("isIdle", false);
		anim.SetBool ("isWalking", false);
		anim.SetBool ("isAttacking", false);
		anim.SetBool ("isDead", true);
		yield return new WaitForSeconds(2f);
		Destroy(gameObject);

	}
}
