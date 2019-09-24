using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//If statements must be inside a function
//If statements only check the Trueness of an exspression
//If statements do not check if its "true"
//It can be True if you ask if it's False
//(==)-means compare this outcome to this outcome.
//Bools are only true or false
//(||)-is an or statements(sees if 1 or the other is true)
//(&&)-sees if two things are true
//Else fallows an if clause-(if it's not true it's false and should follow the Else clause) 

public class IFstatements : MonoBehaviour
{

	public int a = 5;
	public int b = 5;
	public int c = 10;
	
	public string password = "Friends";
	public bool lightsOn = false;
	
	// Use this for initialization
	void Start ()
	{
		if (a+b==c)
		{
			print("True.");
		}

		if (password != "OU812") ;
		{
			print("access");
		}
		if (!lightsOn)
		{
			print("True!");
		}
		else
		{
			print("false");
		}
		
	}
	
}
