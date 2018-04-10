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


	// When it triggers : player can start interrogation
	public virtual void Interact()
	{
		Debug.Log ("Interacting with base class");
	}

	public virtual void DoAnimation()
	{
		Debug.Log ("Animation with base class");
	}


}
