using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonEnemy : MonoBehaviour
{
	public int EnemyHealth = 10;
	public Animator anim;
	public int BasedXp = 10;
	public int CalculatedExp;

	void DeductPoints(int DamageAmount)
	{
		EnemyHealth -= DamageAmount;
		if (EnemyHealth <= 0) 
		{
			CalculatedExp = BasedXp * GlobalLevel.CurrentLevel;
			GlobalEXP.CurrentExp += CalculatedExp;
		}
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
		anim.SetBool ("isIdle", false);
		anim.SetBool ("isWalking", false);
		anim.SetBool ("isAttacking", false);
		anim.SetBool ("isDead", true);
		yield return new WaitForSeconds(2f);
		Destroy(gameObject);

	}
}
