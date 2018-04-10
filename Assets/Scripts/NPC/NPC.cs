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
	private bool iInteracted;

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
	}


}
