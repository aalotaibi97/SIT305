/// <summary>
/// Game manager.
/// AUTHOR : ALI ALOTAIBI
/// This class is used for :
/// - Saving JSON data to project persistent path
/// - Lading JSON data from project persitent data path
/// </summary>
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GameManager : MonoBehaviour {

	public static GameManager _instance;

	public void Awake()
	{
		_instance = this;						// Creating the singleton instance of this "GAMEMANAGER" class
		DontDestroyOnLoad (this);
	}


	/*
	 *  SAVING THE JSON DATA : passing argument json_string and json file name
	*/
	public void SaveJSONInfo(string jsonData,string jsonName)
	{
		string path = null;
		#if UNITY_EDITOR
		path = Application.dataPath +"/"+jsonName;
		//path = "Assets/Resources/GameJSONData/"+jsonName+".json";
		Debug.Log ("PATH : " + path);
		#endif
		#if UNITY_STANDALONE
		// You cannot add a subfolder, at least it does not work for me
		//path = "/Resources/"+jsonName+".json";
		path = Application.persistentDataPath +"/"+jsonName;
		Debug.Log ("PATH : " + path);
		#endif

		string str = jsonData.ToString();
		using (FileStream fs = new FileStream(path, FileMode.Create)){
			using (StreamWriter writer = new StreamWriter(fs)){
				writer.Write(str);
			}
		}
		#if UNITY_EDITOR
		UnityEditor.AssetDatabase.Refresh ();
		#endif
	}

	/*
	 *  LOADING THE JSON DATA : passing argument json file name
	*/
	public string LoadJSONInfo(string jsonName)
	{
		// Path.Combine combines strings into a file path
		// Application.StreamingAssets points to Assets/StreamingAssets in the Editor, and the StreamingAssets folder in a build
		//string filePath = Path.Combine(Application.streamingAssetsPath, scene1Doalog_FileName);
		string filePath = null;// Application.persistentDataPath +"/"+scene1Doalog_FileName;
		string dataAsJson=null;

		#if UNITY_EDITOR
		filePath = "Assets/Resources/GameJSONData/"+jsonName;
		//filePath = Application.dataPath +"/"+jsonName;
		//path = "Assets/Resources/GameJSONData/"+jsonName+".json";
		#endif
		#if UNITY_STANDALONE
		// You cannot add a subfolder, at least it does not work for me
		//path = "/Resources/"+jsonName+".json";
		filePath = Application.persistentDataPath +"/"+jsonName;
		#endif

		if(File.Exists(filePath))
		{
			// Read the json from the file into a string
			dataAsJson = File.ReadAllText(filePath); 
			return dataAsJson;

		}
		else
		{
			dataAsJson = "Cannot load game data!";
			return dataAsJson;
		}
	}
}
