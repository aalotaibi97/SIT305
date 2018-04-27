using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

	public GameObject _infoPopup;

	public GameObject character;

	public void ShowInfoPopup(string s)
	{
		_infoPopup.SetActive (true);
		_infoPopup.GetComponentInChildren<Text> ().text = s;
	}

	void Update () {

		if (Input.GetKey(KeyCode.RightArrow)){

			Vector3 newPosition = character.transform.position;
			newPosition.x++;
			character.transform.position = newPosition;

		}
		if (Input.GetKey(KeyCode.LeftArrow)){

			Vector3 newPosition = character.transform.position;
			newPosition.x--;
			character.transform.position = newPosition;

		}
		if (Input.GetKey(KeyCode.UpArrow)){

			Vector3 newPosition = character.transform.position;
			newPosition.z++;
			character.transform.position = newPosition;

		}
		if (Input.GetKey(KeyCode.DownArrow)){

			Vector3 newPosition = character.transform.position;
			newPosition.z--;
			character.transform.position -= newPosition;

		}

	}
}
