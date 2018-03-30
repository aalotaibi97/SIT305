/// <summary>
/// ALI ALOTAIBI
/// Dialogue. 
/// Dialogue structure class : used for json serilization and de-serialization
/// </summary>
using System;
using System.Collections.Generic;

[Serializable]	
public class Dialogue {

	public int diagId;
	public string actor_1;
	public string actor_2;
	public List<DialogueString> _dialogList;

}

[Serializable]
public class DialogueString
{
	public string speaker;
	public string dialogue;
}
