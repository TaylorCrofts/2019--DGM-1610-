using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.Events;

public class NoteScript : MonoBehaviour
{
	public float floatValue = 5.5f;
	public int intValue = 20;
	public string stringValue = "Ghost";
	public UnityEvent Event;
	public int firepower = 1;

	private void OnTriggerEnter(Collider other)
	{
		Event.Invoke();
		print("Hello Spirit");
	}
}

//Need to find and figure out what oftype is
//I want the Circle to become the player and the square to "disappear" until (X) is pressed on the keyboard
//I then want the circle to freeze where it's at and have the square reappear.
	//private void OnCollisionExit(Collider other)
	//{
	//	Event.Invoke();
	//	print("Jiggly");
	//}
