using System;
using UnityEngine;

namespace ScriptsFromClass
{
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
}
