using UnityEngine;

	public class IfStatements : MonoBehaviour
	{
		public int a = 5;
		public int b = 5;
		public int c = 10;
	
		public string password = "Friends";
		public bool lightsOn;
		
		void Start ()
		{
			if (a+b==c)
			{
				print("True.");
				lightsOn = true;
			}

			if (password != "Friends"); 
			{
				print("no access");
				lightsOn = false;
			}
			print(!lightsOn ? "True!" : "false");
		}
	}
