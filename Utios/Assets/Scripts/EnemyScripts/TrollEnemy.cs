using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrollEnemy : MonoBehaviour
{

	public int EnemyHealth = 20;
	public Animator anim;
	public int BasedXp = 20;
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
			anim.gameObject.GetComponent<ChaseTroll>().Dead();
		}
	}
	
	IEnumerator DeathSkeleton()
	{
		anim.SetBool ("walk", false);
		anim.SetBool ("run", false);
		anim.SetBool ("damage", false);
		anim.SetBool ("idle01", false);
		anim.SetBool ("attack03", false);
		anim.SetBool ("dead", true);
		yield return new WaitForSeconds(4f);
		Destroy(gameObject);
		
	}
}
