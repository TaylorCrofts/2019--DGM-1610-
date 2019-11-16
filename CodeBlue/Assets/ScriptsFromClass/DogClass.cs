
using UnityEngine;

namespace ScriptsFromClass
{
	public class DogClass : MonoBehaviour
	{
		public UnityEngine.Events.UnityEvent doesStuff;
		private void OnMouseDown()
		{
			doesStuff.Invoke();
		}
	}
}

