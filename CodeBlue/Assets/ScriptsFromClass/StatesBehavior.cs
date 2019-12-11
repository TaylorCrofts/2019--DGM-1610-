using UnityEngine;
using UnityEngine.Events;

public class StatesBehavior : StateMachineBehaviour
{
	public UnityEvent startEnterEvent, stateUpdate, stateExit;
	
	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	startEnterEvent.Invoke();
	}

	
	override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) 
	{
	stateUpdate.Invoke();
	}

	
	override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	stateExit.Invoke();
	}
	
}
