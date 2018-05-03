using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene2_1Manager : MonoBehaviour {

	public static Scene2_1Manager instance;

	public LerpFade _lerpFade;
	public GameObject _panel_Chat;

	public GameObject _suspectPanel;
	public string suspectedPerson;
	public Text _suspectedText;

	public List<string> _ListSuspected = new List<string> ();
	public List<string> _ListPersons = new List<string> ();

	public GameObject _panelSuspectedItem;

	int allEvidenceObserved;

	public GameObject panel_chose_gameover;

	public GameObject gameoverPanel;
	public string gameover_Win = "Case Solved: So the murderer was “Maid”, as when the Detective finds out the empty mail box and on Sundays mail did not get delivered as post offices are closed on Sundays.\n\nReason: Maid killed the wife of Ronald, as she wants to get money from all her account and transfer them to her own account. But Ronald’s wife caught maid red-handed stealing money.";
	public string gameover_fail = "Case Un-Solved: Still it is mystery. TRY AGAIN !!";
	public Button gameover_OkButton;

	void Awake()
	{
		//_lerpFade.White (0.01f);
		instance = this;
	}

	// Use this for initialization
	IEnumerator  Start () {

		yield return new WaitForSeconds (1.0f);
		_lerpFade.Light_white (2.0f);
	}
	
	public void OpenSuspectPanel()
	{
		Invoke ("ShowNow", 1.5f);    // Wait for 1.5 seconds to show Panel
	}

	void ShowNow()
	{
		_suspectedText.text = "Is " + suspectedPerson + " suspected to murderer.";
		_suspectPanel.SetActive (true);
	}

	public void ToSuspect(bool yes)
	{
		if (yes)
			_ListSuspected.Add (suspectedPerson);			// Adding suspected person to  list 
		else
			_ListPersons.Add (suspectedPerson);

		_suspectPanel.SetActive (false);

		allEvidenceObserved++;

		Invoke ("CheckAllItemsObserved", 2.0f);
	}

	public void OpenSuspectedItem(string s)
	{
		_panelSuspectedItem.GetComponent<Panel_SuspectedItem> ().suspectedItem = s;
		_panelSuspectedItem.gameObject.SetActive (true);

		allEvidenceObserved++;

		Invoke ("CheckAllItemsObserved", 2.0f);
	}

	void CheckAllItemsObserved()
	{
		if (allEvidenceObserved < 6)
			return;

		// Open the gameover to chose the murderer
		panel_chose_gameover.gameObject.SetActive(true);
	}
}
