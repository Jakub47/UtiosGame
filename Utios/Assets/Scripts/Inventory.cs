using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour 
{
	//public
		
	//HUD
	public Texture2D[] healthStatus;
	public RawImage healthStatusGUI;

	public Texture2D[] manaStatus;
	public RawImage manaStatusGUI;
	public Texture2D[] staminaStatus;
	public RawImage staminaStatusGUI;

	//static
	public static int health = 5;
	public static int mana = 5;
	public static int stamina = 5;

	// Use this for initialization
	void Start () 
	{
		health = mana = stamina = 4;	
		healthStatusGUI.texture = healthStatus[health];
		manaStatusGUI.texture = manaStatus[mana];
		staminaStatusGUI.texture = staminaStatus[stamina];
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void HeathPickUp()
	{
		if(health < 5)
		{
			health++;
			healthStatusGUI.texture = healthStatus[health];
		}
		Debug.Log("health is " + health);
		Debug.Log("mana is " + mana);
		Debug.Log("stamina is " + stamina);

	}
}
