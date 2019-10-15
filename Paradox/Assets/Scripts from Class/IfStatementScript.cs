using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatementScript : MonoBehaviour
{
	public int a = 1;
	public int b = 8;
	public int c = 7;
	public string code = "Error";
	public bool lightOn = false;
	void Start () 
	{
		if (a+b>c)
		{
			print(true);
		}
		else if (code !="Access")
		{
			print(true);
		}
		else if (!lightOn)
		{
			print(true);
		}
		else
		{
			print(false);
		}
	}
	}

