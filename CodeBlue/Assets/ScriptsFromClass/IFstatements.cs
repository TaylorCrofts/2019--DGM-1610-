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

namespace ScriptsFromClass
{
	public class IFstatements : MonoBehaviour
	{

		public int a = 5;
		public int b = 5;
		public int c = 10;
	
		public string password = "Friends";
		public bool lightsOn = false;
		void Start ()
		{
			if (a+b==c)
			{
				print("True.");
				lightsOn = true;
			}

			if (password != "Friends") ; 
			{
				print("no access");
				lightsOn = false;
			}
			print(!lightsOn ? "True!" : "false");
		}
		
	
	}
}
