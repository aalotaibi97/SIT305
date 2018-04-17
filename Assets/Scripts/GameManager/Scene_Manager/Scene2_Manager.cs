using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene2_Manager : MonoBehaviour {

	public LerpFade _lerpFade;

	public GameObject _houseBG;

	public GameObject _text1,_text2;

	void Awake()
	{
		_lerpFade.Dark (0.25f);
	}

	// Use this for initialization
	IEnumerator Start () 
	{
		_lerpFade.Light (2.0f);

		yield return null;

		yield return new WaitForSeconds (1.5f);
		_text1.SetActive (true);
		yield return new WaitForSeconds (0.5f);
		_text2.SetActive (true);

		yield return new WaitForSeconds (1.0f);

		yield return StartCoroutine ("BgScale");

		_lerpFade.White (0.5f);

		yield return new WaitForSeconds (1.0f);


		SceneManager.LoadScene ("scene_2_1");
	}

	IEnumerator BgScale()
	{
		yield return new WaitForSeconds (5.0f);

		Vector3 start = new Vector3 (1.0f, 1.0f, 1.0f);
		Vector3 end = new Vector3 (5.806806f, 5.806806f, 5.806806f);
		float progress = 0; //This float will serve as the 3rd parameter of the lerp function.
		float increment = 0.02f/4.0f; //The amount of change to apply.
		while(progress < 1)
		{
			Vector3 sc = Vector3.Lerp(start,end, progress);
			progress += increment;
			_houseBG.transform.localScale = new Vector3 (sc.x, sc.y, sc.z);
			yield return null;
		}
		yield return new WaitForSeconds(1.0f);
	}

}
