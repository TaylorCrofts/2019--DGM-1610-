using System.Diagnostics;
using UnityEngine;

namespace ScriptsFromClass
{
	public class DebuggerHandler : MonoBehaviour
	{

		public Debugger debuggerObj;

		public void SwitchDebugger(Debugger newDebuggerObj)
		{
			debuggerObj = newDebuggerObj;
		}
	}
}
