using UnityEngine;
using UnityEngine.Events;

namespace ScriptsFromClass
{
	public class CatClass : MonoBehaviour
	{
		public UnityEvent CatLight;
		public void OnMouseDown()
		{
			CatLight.Invoke();
		}
	}
}
