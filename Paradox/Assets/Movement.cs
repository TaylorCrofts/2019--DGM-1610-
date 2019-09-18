
using UnityEngine;
using UnityEngine.Experimental.UIElements.StyleEnums;

public class Movement : MonoBehaviour
{
	public float speed = 5f;
	public float gravity = 5f;
	public float jumpSpeed = 10f;

	private Vector3 position;
	public CharacterController controller;
	void Update ()
	{
		position.x = speed * Input.GetAxis("Horizontal");
		if (!controller.isGrounded)
		{
			position.y +=gravity;
		}

		if (Input.GetButtonDown("Jump"))
		{
			position.y = jumpSpeed;
		}

		controller.Move(position * Time.deltaTime);
	}
}
