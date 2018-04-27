using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC_DialoguePanel : MonoBehaviour {

	public List<Diag_Editor> _diagList;


	public Image speaker_1;
	public Image speaker_2;

	public TMPro.TextMeshProUGUI _diag_1;
	public TMPro.TextMeshProUGUI _diag_2;

	public Button _continue;

	void OnEnable()
	{
		_diag_1.text = "";
		_diag_2.text = "";	
		indexID = 0;
		_continue.onClick.AddListener (Continue);			// Adding event listeners from Button "Continue"
		StartCoroutine ("StartSpeech");
	}

	// Pre-Defined method from mono behaviour class : on_disable of gameobject
	void OnDisable()
	{
		_continue.onClick.RemoveAllListeners ();			// Removing event listeners from Button "Continue"
	}


//	public void Show(List<Diag_Editor> _d,Sprite s)
//	{
//		_diagList = _d;
//		speaker_2.sprite = s;
//	}



	/*
	 *  Initiating the Dialog speech from index 0 of the dialgue list
	 */
	public int indexID=0;
	IEnumerator StartSpeech()
	{
		_continue.interactable = false;

		yield return new WaitForSeconds (1.0f);

		if (indexID < _diagList.Count) 
		{
			_diag_1.text = _diagList [indexID].dialogue;
			indexID++;
		}
		else
			_continue.interactable = true;

		yield return new WaitForSeconds (2.0f);

		if (indexID < _diagList.Count) 
		{
			_diag_2.text = _diagList [indexID].dialogue;
			indexID++;
		}
		else
			_continue.interactable = true;
		
		yield return new WaitForSeconds (2.0f);
		_continue.interactable = true;
	}

	// Increasing the cointer for dialogue string
	void Continue()
	{
		if (indexID < _diagList.Count) 
		{
			_diag_1.text = "";
			_diag_2.text = "";	
			StartCoroutine ("StartSpeech");
		}
		else 
		{
			StopCoroutine ("StartSpeech");
			indexID = 0;
			//Once the dialogue sppech get completed : showing the New Panel To suspect it or not
			Scene2_1Manager.instance.OpenSuspectPanel ();
			this.gameObject.SetActive (false);
		}
	}
}
