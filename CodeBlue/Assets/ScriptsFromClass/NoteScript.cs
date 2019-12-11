using UnityEngine;
using UnityEngine.Events;

namespace ScriptsFromClass
{
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
}

