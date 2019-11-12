using System.Diagnostics;
using UnityEngine;

public class DebugHandlingScript : MonoBehaviour
{
    public Debugger debuggerObj;

        public void SwitchDebugger(Debugger newDebuggerObj)
        {
            debuggerObj = newDebuggerObj;
        }
    
        void Update()
        {
            debuggerObj.OnDebug();
        }
    }
