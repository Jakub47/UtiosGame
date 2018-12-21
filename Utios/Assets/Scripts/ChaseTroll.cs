using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseTroll : MonoBehaviour 
{
	public Transform player;
	static Animator anim;
	private bool isDead;
	
	// Use this for initialization
	void Start () 
	{
		anim = GetComponent<Animator> ();
		isDead = false;
	}
	
	public void Dead()
	{
		isDead = true;
	}
	
	// Update is called once per frame
	void Update ()
	{
		Vector3 direction = player.position - this.transform.position; //Get the Actual distance from player to enemy
		
		//Now we need to sneak behind him so we must calculate the angle 
		float angle = Vector3.Angle (direction, this.transform.forward);
		
		//If Position is smaller than 10 from you and enemy!
		if (Vector3.Distance (player.position, this.transform.position) < 10 && angle < 30 && !isDead) {
			
			/*Now he will also do some "matrix stuff" with that rotation because we're calculating the direction vector	
			 * between him and player. If you will stand above him then the angle is going to be much sharper, so it's j
			 * just constantly keep moving for us in that way. 
			 * 	Now we want to take the y-axis or the height diffrence OUT OF THE EQUATION!*/
			direction.y = 0;
			
			//Make it rotate to player
			this.transform.rotation = Quaternion.Slerp (this.transform.rotation,
			                                            Quaternion.LookRotation (direction), 0.1f);
			
			//Okay so we should set it to false because we will start walking
			anim.SetBool ("idle01", false);
			
			//magnitude == length of vector
			if (direction.magnitude > 5 ) 
			{
				this.transform.Translate (0, 0, 0.05f);
				anim.SetBool ("walk", true);
				anim.SetBool ("run", false);
				anim.SetBool ("damage", false);
				anim.SetBool ("idle01", false);
				anim.SetBool ("attack03", false);
			}
			else
			{
				anim.SetBool ("attack03", true);
				anim.SetBool ("walk", false);
				anim.SetBool ("run", false);
				anim.SetBool ("damage", false);
				anim.SetBool ("idle01", false);
			}
			
		} 
		else 
		{
			//Okay so if we are far aways just turn off all animations except the idle one
			anim.SetBool ("idle01", true);
			anim.SetBool ("walk", false);
			anim.SetBool ("run", false);
			anim.SetBool ("damage", false);
			anim.SetBool ("attack03", false);
			
		}
	}
}
