
using UnityEngine;
using UnityEngine.Events;

public class ParticalSystemScript : MonoBehaviour
{
	private void OnMouseDown()
	{
		particles.Emit(100);
	}

	public ParticleSystem particles;
	
}
