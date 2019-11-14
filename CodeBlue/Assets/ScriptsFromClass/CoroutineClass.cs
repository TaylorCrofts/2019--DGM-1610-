using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineClass : MonoBehaviour
{
	public IntData index;
	public float seconds = 10f;
	private WaitForSeconds wfsObj;
	public UnityEvent startCoroutine, OnCoroutine, endCoroutine;
	public bool canRun = true;

	public void Run()
	{
		
		wfsObj= new WaitForSeconds(seconds);
		StartCoroutine(OnRun());
	}
	
	IEnumerator OnRun () //Start on mouse down works 
	{
		startCoroutine.Invoke();
		while (canRun)
		{
			yield return new WaitForSeconds(1f);
			
		}
	}
	

}
//Use to delay things like an Event
//Use to count things like (loading, starting(race start count down)
