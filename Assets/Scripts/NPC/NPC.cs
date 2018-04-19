/// <summary>
/// NPC
/// Author : ALI ALOTAIBI
/// 
/// </summary>
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : Interactable {

	[SerializeField]
	public  bool iInteracted;

	public TextAsset _myConversation;
	private string jsonData;
	public List<Diag_Editor> _diagList = new List<Diag_Editor>();

	// Interaction for dialogue
	public override void Interact ()
	{
		base.Interact ();
	}

	public override void DoAnimation ()
	{
		base.DoAnimation ();
	}

	public void PlayerInnterrogation(GameObject g)
	{
		Debug.Log (g.name + " is interacting with " + this.gameObject.name);
		iInteracted = true;

//		if (!g.GetComponent<PlayerController> ()._animationModel.GetCurrentAnimatorStateInfo (0).IsName ("talk_1") && iInteracted == true)
//			g.GetComponent<PlayerController> ()._animationModel.Play ("talk_1");


		// ShowCAnVAS OF SPPECH
		Scene2_1Manager.instance._panel_Chat.SetActive(true);
		Scene2_1Manager.instance._panel_Chat.GetComponent<NPC_DialoguePanel> ()._diagList = this._diagList;
	}

	void Start()
	{
		// Load JSon data of conversation and parse from text file
		LoadConversation();
	}

	// Loading conversation for each NPC character at start of scene
	void LoadConversation()
	{
		jsonData = _myConversation.text;

		Diag_Editor_JSON js = JsonUtility.FromJson<Diag_Editor_JSON> (jsonData);

		_diagList.Clear ();
		foreach(Diag_Editor d in js._dialogList)
		{
			_diagList.Add (d);
		}

//		foreach(Diag_Editor d in js._dialogList)
//		{
//			Debug.Log (d.speaker + "\t" + d.dialogue);
//		}
	}
}
