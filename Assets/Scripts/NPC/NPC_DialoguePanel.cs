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
		StartCoroutine ("StartSpeech");

		_continue.onClick.AddListener (Continue);
	}

	int indexID=0;
	IEnumerator StartSpeech()
	{
		_continue.interactable = false;

		yield return new WaitForSeconds (1.0f);

		if (indexID < _diagList.Count) 
			_diag_1.text = _diagList [indexID].dialogue;
		else
			_continue.interactable = true;

		indexID++;

		yield return new WaitForSeconds (2.0f);

		if (indexID < _diagList.Count) 
			_diag_2.text = _diagList [indexID].dialogue;
		else
			_continue.interactable = true;

		yield return new WaitForSeconds (2.0f);

		indexID++;

		_continue.interactable = true;


	}

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
			indexID = 0;
			this.gameObject.SetActive (false);
		}
	}
}
