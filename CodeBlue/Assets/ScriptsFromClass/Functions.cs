using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

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
		Newplayer.SetActive (true);
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
		print(WelcomePlayer());
		return playerName + "welcome to the game!";
	}

	private int AddNumbers(int a, int b)
	{
		print("A+B");
		return a+b;
		
	}
	
}
