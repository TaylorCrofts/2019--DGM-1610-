using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
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
