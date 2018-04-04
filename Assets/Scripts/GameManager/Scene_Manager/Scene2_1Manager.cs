using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene2_1Manager : MonoBehaviour {

	public LerpFade _lerpFade;

	void OnEnable()
	{
		
	}

	void Awake()
	{
		//_lerpFade.White (0.01f);
	}

	// Use this for initialization
	IEnumerator  Start () {

		yield return new WaitForSeconds (1.0f);

		_lerpFade.Light_white (2.0f);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
