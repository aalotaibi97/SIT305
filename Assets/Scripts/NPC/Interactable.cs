/// <summary>
/// Interactable.
///  
/// Author : ALI ALOTAIBI
/// 
/// Define base Class for NPC Characters 
/// 
/// 
/// </summary>
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Interactable : MonoBehaviour {

	public NavMeshAgent playerAgent;

	// Player click to get interaction : player moves to interrrgate
	public virtual void MoveToInteraction(NavMeshAgent playerAgent)
	{
		this.playerAgent = playerAgent;
		playerAgent.destination = this.transform.position;
	}

	// When it triggers : player can start interrogation
	public virtual void Interact()
	{
		Debug.Log ("Interacting with base class");
	}
}
