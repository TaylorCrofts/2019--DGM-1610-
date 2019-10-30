using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
//(=) means assign too
//These functions give you back stuff
//use them when you know you want the same option to be repeated several times.
//Unity Events must have a return type of void. 
//(instansiate) means to create.
//build stuff and turn it into a prefab
//If were declaring a float we must return a float ect...
public class Functions : MonoBehaviour
{
	public Color playercolor= Color.red;
	
	public string playerName;
	private int myNumber;
	public float Speed = 5;
	public GameObject player;
	void Start ()
	{
		Instantiate(ConfigGameObject());
	}

	private GameObject ConfigGameObject()
	{
		var Newplayer = Instantiate(player);
		Newplayer.layer = 0; 
		Newplayer.active = true;
		Newplayer.tag = "Player";
		Newplayer.transform.position=Vector3.zero;
		Newplayer.name = playerName;
		
		return Newplayer;  
	}
	
	private float IncreaseSpeed(float multiplier)
	{
		return Speed * multiplier;
	}

	private void OnTriggerEnter(Collider other)
	{
		Speed = IncreaseSpeed(2f);
	}

	private string WelcomePlayer()
	{
		//add player to database
		//give player weapon
		print(WelcomePlayer());
		return playerName + "welcome to the game!";
	}

	private int AddNumbers(int a, int b)
	{
		print("A+B");
		return a+b;
		
	}
	
}
