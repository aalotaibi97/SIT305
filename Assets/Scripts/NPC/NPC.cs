/// <summary>
/// NPC
/// Author : ALI ALOTAIBI
/// 
/// </summary>
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : Interactable {

	public Actor _myName;		//Name of NPC players

	//Player is inteactiong
	public override void MoveToInteraction (UnityEngine.AI.NavMeshAgent playerAgent)
	{
		base.MoveToInteraction (playerAgent);
	}

	// Interaction for dialogue
	public override void Interact ()
	{
		base.Interact ();
	}
}
