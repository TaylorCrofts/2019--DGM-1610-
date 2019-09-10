using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.Events;

public class NewGhostScript : MonoBehaviour
{
	public float floatValue = 5.5f;
	public int intValue = 20;
	public string stringValue = "Reaper";
	public UnityEvent Event;

	private void OnTriggerEnter(Collider other)
	{
		Event.Invoke();
		print("Hello Spirit");
	}

	private void Start()
	{
		
	}
}
