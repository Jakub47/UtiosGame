using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest001Buttons : MonoBehaviour 
{
	public GameObject ThePlayer;
	public GameObject NoticeCam;
	public GameObject UIQuest;
	public GameObject ActiveQuestBox;
	public GameObject Objective01;
	public GameObject Objective02;
	public GameObject Objective03;


	public void AcceptQuest()
	{
		Debug.Log ("dasd");
		ThePlayer.SetActive (true);
		NoticeCam.SetActive (false);
		UIQuest.SetActive (false);
		StartCoroutine (SetQuestUI ());
	}

	IEnumerator SetQuestUI()
	{
		ActiveQuestBox.GetComponent<Text> ().text = "My First weapon";
		Objective01.GetComponent<Text> ().text = "Reach the old house";
		Objective02.GetComponent<Text> ().text = "Open the chest";
		Objective01.GetComponent<Text> ().text = "Retrieve the weapon";
		QuestManager.ActiveQuestNumber = 1;

		yield return new WaitForSeconds(0.5f);
		//animations will play automatically so there is no need to play it
		ActiveQuestBox.SetActive (true);

		yield return new WaitForSeconds(1f);
		Objective01.SetActive (true);

		yield return new WaitForSeconds(0.5f);
		Objective02.SetActive (true);

		yield return new WaitForSeconds(0.5f);
		Objective03.SetActive (true);

		yield return new WaitForSeconds(9);
		ActiveQuestBox.SetActive (false);
		Objective01.SetActive (false);
		Objective02.SetActive (false);
		Objective03.SetActive (false);

	}

	public void DeclineQuest()
	{
		ThePlayer.SetActive (true);
		NoticeCam.SetActive (false);
		UIQuest.SetActive (false);
	}
}
