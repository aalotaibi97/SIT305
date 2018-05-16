using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panel_SuspectedItem : MonoBehaviour {

	public Sprite _knife;
	public Sprite _mail;
    public Sprite _mobile;

    public Text _headText;
	public Text _descText;

	public Image _spriteImage;

//	public string headString;
//	public string descString;

	public string suspectedItem;

	void OnEnable()
	{
//		_headText.text = headString;
//		_descText.text = descString;


		switch (suspectedItem) 
		{
		case "mail":
			_headText.text = "MAIL LETTERS";
			_descText.text = "Is mail letters concern to maid ? Thinkable !!";
			_spriteImage.sprite = _mail;
			break;
		case "Knife":
			_spriteImage.sprite = _knife;
			_headText.text = "KNIFE";
			_descText.text = "Knife founds at improper place. Might murder happened using this. But who ?";
			break;
        case "mobile":
            _spriteImage.sprite = _mobile;
            _headText.text = "MOBILE PHONE";
            _descText.text = "We have to investigate call log details. May be found some evidence.";
            break;
        }

		_spriteImage.SetNativeSize ();
	}

	public void Close()
	{
		this.gameObject.SetActive (false);	
	}
}
