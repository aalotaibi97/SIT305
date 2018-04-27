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
		_continue.onClick.AddListener (Continue);
		StartCoroutine ("StartSpeech");


	}

	void OnDisable()
	{
		_continue.onClick.RemoveAllListeners ();
	}


//	public void Show(List<Diag_Editor> _d,Sprite s)
//	{
//		_diagList = _d;
//		speaker_2.sprite = s;
//	}

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

			Scene2_1Manager.instance.OpenSuspectPanel ();

			this.gameObject.SetActive (false);


		}
			
	}
}
