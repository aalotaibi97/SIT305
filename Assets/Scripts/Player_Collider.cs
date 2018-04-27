using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player_Collider : MonoBehaviour {

	public Dictionary<string,string> _triggerInfo= new Dictionary<string, string>();

	void Start()
	{
		GameObject[] gos;
		gos = GameObject.FindGameObjectsWithTag("InfoCollider");

		foreach (GameObject g in gos) 
		{
			_triggerInfo.Add (g.name, g.GetComponent<InfoValue> ().popupString);
		}

		Debug.Log (_triggerInfo.Count);
	}


	void OnTriggerEnter(Collider col)
	{
		Debug.Log ("TRIGGER "+col.gameObject.name);
		if (_triggerInfo.ContainsKey (col.gameObject.name))
			SendMessage ("ShowInfoPopup", _triggerInfo[col.gameObject.name]);
	}

	void OnCollisionEnter(Collision col)
	{
		Debug.Log ("COLLISION "+col.gameObject.name);
	}
}
