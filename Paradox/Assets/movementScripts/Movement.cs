using UnityEngine;
public class Movement : MonoBehaviour
{
	public float speed = 5f;
	public float gravity = 5f;
	public float jumpSpeed = 10f;

	private int jumpcount = 1;
	
	private Vector3 position;
	
	public CharacterController controller;
	void Update ()
	{
		position.x = speed*Input.GetAxis("Horizontal");

		if (!controller.isGrounded)
		{
			position.y += gravity;
		}

		else
		{
			jumpcount = 1;
		}
		
		if (Input.GetButtonDown("Jump") && jumpcount > 0)
		{
			position.y = jumpSpeed;
			jumpcount--;
		}

		controller.Move(position * Time.deltaTime);
	}
}
//The public (Float)'s are given a name and assigned a value which the program can understand. 
