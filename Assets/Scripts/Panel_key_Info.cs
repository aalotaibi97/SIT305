using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel_key_Info : MonoBehaviour {


	void OnEnable()
	{
		Invoke ("Hide",3.0f);
	}

	void Hide()
	{
		this.gameObject.SetActive (false);
	}
}
