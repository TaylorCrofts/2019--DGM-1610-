using JetBrains.Annotations;
using UnityEngine;

public class Movement : MonoBehaviour
{
	public float speed = 1f;
	public float gravity = -3f;
	public float jumpSpeed = 100;
	
	public Vector3 position;
	public CharacterController controller;

	private int jumpcount = 2;
	
	void Update ()
	{
		position.x = speed*Input.GetAxis("Horizontal");

		if (!controller.isGrounded);
		{
			position.y -= gravity;
		}

		if (Input.GetButtonDown("Jump"))
		{
			position.y = jumpSpeed;
		}
		//transform.Translate(position*Time.deltaTime);
		position.y -= gravity;
		
		position *= gravity;
		controller.Move(position*Time.deltaTime);
	}
}
