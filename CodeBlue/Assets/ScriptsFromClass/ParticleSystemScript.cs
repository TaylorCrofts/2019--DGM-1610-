using UnityEngine;

namespace ScriptsFromClass
{
	public class ParticleSystemScript : MonoBehaviour
	{
		public ParticleSystem particles;
		private void OnMouseDown()
		{
			particles.Emit(100);
		}

	
	
	}
}
