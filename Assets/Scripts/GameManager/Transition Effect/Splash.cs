using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Splash : MonoBehaviour {

	public GameObject panel_fade;	// used for fade transition

	// Use this for initialization
	IEnumerator Start () 
	{
		yield return new WaitForSeconds (3.0f);

		panel_fade.SetActive (true);

		yield return new WaitForSeconds (1.5f);

		SceneManager.LoadScene ("play_scene");
	}
	

}
