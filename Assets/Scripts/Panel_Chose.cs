using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
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
			Scene2_1Manager.instance._displayImage.sprite = Scene2_1Manager.instance._winSprite;
			Scene2_1Manager.instance._displayImage.SetNativeSize ();
            Scene2_1Manager.instance.gameover_OkButton.onClick.RemoveAllListeners();
            Scene2_1Manager.instance.gameover_OkButton.onClick.AddListener(LoadSceneAgain);
            Scene2_1Manager.instance.gameover_replayBtn.gameObject.SetActive(false);
        }
		else
		{
			//Show Fail Text
			Debug.Log ("I FALED TO CHOOSED MURDERER");
			Scene2_1Manager.instance.gameoverPanel.SetActive (true);
			Scene2_1Manager.instance.gameoverPanel.GetComponentInChildren<TMPro.TextMeshProUGUI> ().text = Scene2_1Manager.instance.gameover_fail;
			Scene2_1Manager.instance.gameover_OkButton.gameObject.GetComponentInChildren<Text> ().text = "TRY AGAIN";
			Scene2_1Manager.instance._displayImage.sprite = Scene2_1Manager.instance._loseSprite;
            Scene2_1Manager.instance.gameover_replayBtn.gameObject.SetActive(true);
            Scene2_1Manager.instance.gameover_OkButton.onClick.RemoveAllListeners();
            
            Scene2_1Manager.instance.gameover_OkButton.onClick.AddListener(TryAgain);
            Scene2_1Manager.instance.gameover_replayBtn.onClick.AddListener(LoadSceneAgain);
            Scene2_1Manager.instance._displayImage.SetNativeSize ();
		}
	}

    public void LoadSceneAgain()
    {
        SceneManager.LoadScene(0);
    }

    public void TryAgain()
    {
        Scene2_1Manager.instance.gameoverPanel.SetActive(false);
    }
}
