using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class DeBugger : ScriptableObject
{
	public void OnDebug (String words)
	{
		Debug.Log(words);
	}

	public void OnDebug()
	{
		Debug.Log(name);

	}
}
