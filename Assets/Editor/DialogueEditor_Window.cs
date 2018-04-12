/// <summary>
/// Dialogue editor window.
/// 
/// This is Editor Class
/// Used for creating the dialogue between the actors
/// At top File name as per scene : string fileName
/// Developer can edit and update the convesation of dialgue between them via saving and loding functionality
/// All dialogue file can be saved into assets
/// 
/// </summary>

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;
using System.IO;

public class DialogueEditor_Window : EditorWindow {

	[MenuItem("Window/Detective RPG Dialogue Editor")]
	public static void ShowWindow()
	{
		EditorWindow.GetWindow<DialogueEditor_Window> ("Detective RPG Dialogue Editor");
	}

	string fileName;
	string []_actor = new string[7] ;
	int selectedActor;

	string copName;
	string detectiveName;
	string husbandName;
	string butlerName;
	string cookName;
	string maidName;
	string gardenerName;


	string chat_1;

	int xOffset;
	int yOffset =550;
	int widthValue;
	int heightValue;

	bool clicked;

	List<Diag_Editor> _diagList = new List<Diag_Editor>();

	Vector2 scrollViewVector = Vector2.zero;

	void OnEnable()
	{
		Debug.Log ("Editor Enable ");
		copName = EditorPrefs.GetString ("cop");
		detectiveName = EditorPrefs.GetString ("detective");
		husbandName = EditorPrefs.GetString ("husband");
		butlerName = EditorPrefs.GetString ("butler");
		cookName = EditorPrefs.GetString ("cook");
		maidName = EditorPrefs.GetString ("maid");
		gardenerName = EditorPrefs.GetString ("gardener");

	}

	void OnDisable()
	{
		Debug.Log ("Editor Disable ");
		EditorPrefs.SetString ("cop",copName);
		EditorPrefs.SetString ("detective",detectiveName);
		EditorPrefs.SetString ("husband",husbandName);
		EditorPrefs.SetString ("butler",butlerName);
		EditorPrefs.SetString ("cook",cookName);
		EditorPrefs.SetString ("maid",maidName);
		EditorPrefs.SetString ("gardener",gardenerName);
	}

	void OnGUI()
	{
		// Window Code
		GUILayout.Label("Create Dialogue here");

		fileName = EditorGUILayout.TextField ("JSON filename", fileName);

		if (GUILayout.Button ("Load convesation from  JSON format of above file name"))
		{
			fileName+=".json";
			Load_Json ();
		}

		copName = EditorGUILayout.TextField ("COP", copName);
		detectiveName = EditorGUILayout.TextField ("DETECTIVE", detectiveName);
		husbandName = EditorGUILayout.TextField ("HUSBAND", husbandName);
		butlerName = EditorGUILayout.TextField ("BUTLER", butlerName);
		cookName = EditorGUILayout.TextField ("COOK", cookName);
		gardenerName = EditorGUILayout.TextField ("GARDENER", gardenerName);
		maidName = EditorGUILayout.TextField ("MAID", maidName);

		_actor[0] = copName;
		_actor[1] = detectiveName;
		_actor[2] = husbandName;
		_actor[3] = butlerName;
		_actor[4] = cookName;
		_actor[5] = maidName;
		_actor[6] = gardenerName;

		if (GUILayout.Button ("Save Converstation in JSON format"))
		{
			fileName+=".json";
			Debug.Log ("Conversation is saving in JSON Format , filename :" + fileName);
			Create_SaveJSON ();
		}

		EditorGUILayout.BeginHorizontal ();
		if (GUILayout.Button ("+ Add more conversation"))
		{
			Debug.Log ("Clicking add");
			AddRow ();
		}
		if (GUILayout.Button ("- Remove last conversation"))
		{
			Debug.Log ("Clicking delete");
			DelRow ();
		}
		EditorGUILayout.EndHorizontal ();

		EditorGUILayout.Space ();
		EditorGUILayout.Space ();
		scrollViewVector = EditorGUILayout.BeginScrollView(scrollViewVector, GUILayout.Width(position.width), GUILayout.Height(position.height-250));
		//scrollViewVector = GUI.BeginScrollView(new Rect(0,250, position.width - 30, position.height-500), scrollViewVector, new Rect(0, 0,400,_diagList.Count*25));
		foreach (Diag_Editor d in _diagList) 
		{
			Diag_Editor oldDiag = d;

			EditorGUILayout.BeginHorizontal ();
			if (d.actorid!=-1)
				selectedActor = d.actorid;
			
			selectedActor = EditorGUILayout.Popup ("",selectedActor, _actor,new GUILayoutOption[]{GUILayout.Width(250)});
			switch (selectedActor) 
			{
			case 0:
				d.speaker = copName;
				break;
			case 1:
				d.speaker = detectiveName;
				break;
			case 2:
				d.speaker = husbandName;
				break;
			case 3:
				d.speaker = butlerName;
				break;
			case 4:
				d.speaker = cookName;
				break;
			case 5:
				d.speaker = maidName;
				break;
			case 6:
				d.speaker = gardenerName;
				break;
			
			}
			d.actorid = selectedActor;
			d.dialogue = EditorGUILayout.TextArea (d.dialogue);
			EditorGUILayout.EndHorizontal ();
			EditorGUILayout.Space ();
		}
		EditorGUILayout.EndScrollView ();
	}

	void AddRow()
	{
		_diagList.Add (new Diag_Editor());
	}

	void DelRow()
	{
		_diagList.Remove (_diagList[_diagList.Count-1]);
	}

	void Create_SaveJSON()
	{
		Diag_Editor_JSON json = new Diag_Editor_JSON ();
		json.scene_id = 1;
		Debug.Log (" LIST LENGTH  " + _diagList.Count);
		foreach (Diag_Editor d in _diagList) 
		{
			json._dialogList.Add (d);
		}

		string jsonstring = EditorJsonUtility.ToJson (json);

		Debug.Log ("JSON CREATED : " + jsonstring);

		SaveItemInfo (jsonstring);
	}

	void Load_Json()
	{
		string filePath = "Assets/Resources/GameJSONData/"+fileName;

		if (File.Exists (filePath)) 
		{
			string dataasJson = File.ReadAllText (filePath);
			Diag_Editor_JSON js = JsonUtility.FromJson<Diag_Editor_JSON> (dataasJson);

			_diagList.Clear ();
			foreach(Diag_Editor d in js._dialogList)
			{
				_diagList.Add (d);
			}
		}
	}

	public void SaveItemInfo(string s){
		string path = null;
		#if UNITY_EDITOR
		path = "Assets/Resources/GameJSONData/"+fileName;
		#endif
		#if UNITY_STANDALONE
		// You cannot add a subfolder, at least it does not work for me
		path = "MyGame_Data/Resources/ItemInfo.json"
		#endif

		string str = s.ToString();
		using (FileStream fs = new FileStream(path, FileMode.Create)){
			using (StreamWriter writer = new StreamWriter(fs)){
				writer.Write(str);
			}
		}
		#if UNITY_EDITOR
		UnityEditor.AssetDatabase.Refresh ();
		#endif
	}
}
