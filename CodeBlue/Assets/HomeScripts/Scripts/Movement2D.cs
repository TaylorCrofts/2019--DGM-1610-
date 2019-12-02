using System;
using UnityEngine;

public class Movement2D : MonoBehaviour
{

	public CharacterController2D controller2D;
	public float horizantalMove=0f;
	public float runSpeed = 50f;

	void Update()
	{
		horizantalMove=Input.GetAxisRaw("Horizontal")*runSpeed;
	}

	private void FixedUpdate()
	{
		controller2D.Move(horizantalMove*Time.fixedDeltaTime,false,false);
	}
}
