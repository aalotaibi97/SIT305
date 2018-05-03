using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Panel_Chose : MonoBehaviour ,IPointerDownHandler{

	public bool iAmMurderer;

	#region IPointerDownHandler implementation
	public void OnPointerDown (PointerEventData eventData)
	{
		ChoseMurderer ();
	}
	#endregion


	public void ChoseMurderer()
	{
		if(iAmMurderer)
		{
			//Show the winner Text
			// Show Chat between Maid and Detective

			Debug.Log ("I CHOOSED MURDERER");
			Scene2_1Manager.instance.gameoverPanel.SetActive (true);
			Scene2_1Manager.instance.gameoverPanel.GetComponentInChildren<TMPro.TextMeshProUGUI> ().text = Scene2_1Manager.instance.gameover_Win;
			Scene2_1Manager.instance.gameover_OkButton.gameObject.GetComponentInChildren<Text> ().text = "GOOD JOB!";
		}
		else
		{
			//Show Fail Text
			Debug.Log ("I FALED TO CHOOSED MURDERER");
			Scene2_1Manager.instance.gameoverPanel.SetActive (true);
			Scene2_1Manager.instance.gameoverPanel.GetComponentInChildren<TMPro.TextMeshProUGUI> ().text = Scene2_1Manager.instance.gameover_fail;
			Scene2_1Manager.instance.gameover_OkButton.gameObject.GetComponentInChildren<Text> ().text = "TRY AGAIN";
		}
	}
}
