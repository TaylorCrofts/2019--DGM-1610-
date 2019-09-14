using UnityEngine;
using UnityEngine.Events;

public class TriggerEvents : MonoBehaviour 
{
	public UnityEvent triggerEvent;
	private void OnTriggerEnter(Collider other)
	{
		triggerEvent.Invoke();
		print("Working!");
	}
	
}
