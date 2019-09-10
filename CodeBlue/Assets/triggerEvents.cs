using System;
using UnityEngine;
using UnityEngine.Events;

public class triggerEvents : MonoBehaviour 
{
	public UnityEvent triggerEvent;
	private void OnTriggerEnter(Collider other)
	{
		triggerEvent.Invoke();
	}
	
}
