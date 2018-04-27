using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Actor : ScriptableObject , ISerializationCallbackReceiver
{
	public string _actorName;
	enum actorType
	{
		Cop,
		Detective,
		NPC
	}
	[SerializeField]
	private actorType _actorType;


	#region ISerializationCallbackReceiver implementation
	public void OnBeforeSerialize ()
	{
		
	}
	public void OnAfterDeserialize ()
	{
		
	}
	#endregion
}
