using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class DebuggerHandler : MonoBehaviour
{

	public Debugger debuggerObj;

	public void SwitchDebugger(Debugger newDebuggerObj)
	{
		debuggerObj = newDebuggerObj;
	}
}
