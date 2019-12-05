using UnityEngine;
using UnityEngine.Events;

public class GameActionHandeler : MonoBehaviour
{
	public GameAction gameActionOBJ;
	public UnityEvent handlerEvent;

	void Start ()
	{
		gameActionOBJ.action=RaiseHandler;
	}
	
	void RaiseHandler()
	{
		handlerEvent.Invoke();
	}

}
