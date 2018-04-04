/// <summary>
/// Scene1 manager.
/// Author : AHMED MOHAMMED ALJOHANI
/// Managing the scene 1
/// Loading the JSON for dialgue between the COP and DETECTIVE
/// </summary>
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scene1_Manager : MonoBehaviour {

	public static Scene1_Manager _instance;

	public GameObject _cop;
	public GameObject _detective;
	public GameObject _phone;

	public GameObject dialoguePanel;
	public GameObject continueBtn;

	private int dialogueIndex=0;
	public TMPro.TextMeshProUGUI speaker;
	public TMPro.TextMeshProUGUI diag;

	public Sprite _copSpeechBubble;
	public Sprite _detectiveSpeechBubble;
	public Image _dialogueImage;

	private string scene1Doalog_FileName = "scene_1.json";

	public List<Actor> _actorList;


	public Dialogue loadedData;

	void Awake()
	{
		_instance = this;
	}

	// CORUTINE START : TO SHOW THE EFFECT BETWEEN THE COP AND DETECTIVE CONVERSATION
	IEnumerator Start()
	{
		dialoguePanel.SetActive (false);
		StartCoroutine ("LoadJSON_Scene_1");

		yield return new WaitForSeconds (4.0f);												//Waiting for 4 secs to play the (PHONE TRING ANIMATION)
		GameObject.Find("Panel_fadeStart").GetComponent<Animator> ().Play ("fade_end");		// effect transition
		yield return new WaitForSeconds (1.0f);
		_phone.SetActive (false);
		GameObject.Find("Panel_fadeStart").GetComponent<Animator> ().Play ("fade_panel");
		yield return new WaitForSeconds (1.0f);
		_cop.SetActive (true);																// Active the gameobject (COP : 2D Sprite)
		yield return new WaitForSeconds (1.0f);
		_dialogueImage.sprite = _copSpeechBubble;
		dialoguePanel.SetActive (true);
		Show_Dialogue (dialogueIndex);
		continueBtn.SetActive (false);
		yield return new WaitForSeconds (3.0f);
		_detective.SetActive (true);														// Active the gameobject (DETECTIVE : 2D Sprite)
		yield return new WaitForSeconds (1.0f);
		Show_Dialogue (dialogueIndex);
		_dialogueImage.sprite = _detectiveSpeechBubble;
		yield return new WaitForSeconds (1.0f);
		continueBtn.SetActive (true);
	}

	//Loading the JSON for dialgue between the COP and DETECTIVE
	IEnumerator LoadJSON_Scene_1()
	{
		yield return null;
		LoadGameData ();
	}

	private void LoadGameData()
	{
		string jsonData = GameManager._instance.LoadJSONInfo (scene1Doalog_FileName);
		loadedData = JsonUtility.FromJson<Dialogue> (jsonData);
		continueBtn.GetComponent<Button>().onClick.AddListener(()=> Show_Dialogue(dialogueIndex));
		Debug.Log ("LOADED JSON : " + loadedData);
	}

	// SHowing progressively speech in the lower panel
	private void Show_Dialogue(int index)
	{
		if (dialogueIndex < loadedData._dialogList.Count) 
		{
			if (loadedData._dialogList [index].speaker == "Roger:")
				_dialogueImage.sprite = _copSpeechBubble;
			if (loadedData._dialogList [index].speaker == "Dan:")
				_dialogueImage.sprite = _detectiveSpeechBubble;
			speaker.text = loadedData._dialogList [index].speaker;
			diag.text = loadedData._dialogList [index].dialogue;

			dialogueIndex++;
		}
		else 
		{
			GameObject.Find("Panel_fadeStart").GetComponent<Animator> ().Play ("fade_end");
			Invoke ("ChangeScene", 1.0f);
		}
	}

	void ChangeScene()
	{
		SceneManager.LoadScene ("scene_2");			//Load the new scene later
	}



}
