using UnityEngine;
using UnityEngine.Events;
//unity event are things the act when called
//invoke is calling it.
public class TriggerEventScript : MonoBehaviour 
{
    public UnityEvent triggerEvent;
    private void OnTriggerEnter(Collider other)
    {
        triggerEvent.Invoke();
        print("I am colliding");
    }
}
