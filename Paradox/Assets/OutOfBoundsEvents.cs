using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OutOfBoundsEvents : MonoBehaviour
{
	public UnityEvent CollisionEvent;
	public void OnTriggerEnter(Collider other)
	{
		print("Death");
	}
}