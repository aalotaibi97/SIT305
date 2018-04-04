/// <summary>
/// Fade management.
/// AUTHOR :ALI ALOTAIBI
/// this Class is used to screen transition fade : using the black screen
/// </summary>
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeManagement : MonoBehaviour {

	void OnEnable()
	{
		this.gameObject.GetComponent<Animator> ().Play ("fade_panel");			//gettin the component of animator and playing the animation of fade-in
	}
}
