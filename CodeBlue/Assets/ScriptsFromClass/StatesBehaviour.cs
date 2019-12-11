using UnityEngine;
using UnityEngine.Events;

public class StatesBehaviour : StateMachineBehaviour
{
    public UnityEvent startEnterEvent, stateUpdateEvent, stateExitEvent;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        startEnterEvent.Invoke();
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        stateUpdateEvent.Invoke();
    }
    
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        stateExitEvent.Invoke();
    }

}
