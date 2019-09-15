using UnityEngine;
using UnityEngine.Events;

public class TriggerEventScript : MonoBehaviour 
{
    public UnityEvent triggerEvent;
    private void OnTriggerEnter(Collider other)
    {
        triggerEvent.Invoke();
        print("I am colliding");
    }
}
