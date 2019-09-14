using UnityEngine;
using UnityEngine.Events;

public class TriggerEventScript : MonoBehaviour
{
	public UnityEvent TriggerEvent;
	public void OnTriggerEnter(Collider other)
	{
		TriggerEvent.Invoke();
		print("pop!");
	}
}
