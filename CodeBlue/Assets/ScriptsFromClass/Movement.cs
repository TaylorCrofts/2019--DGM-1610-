using JetBrains.Annotations;
using UnityEngine;

namespace ScriptsFromClass
{
	public class Movement : MonoBehaviour
	{
		
		public float speed = 7.1f;
		public float gravity = 5.2f;
		public float jumpSpeed = -1.1f;
	
		public Vector3 position;
		public CharacterController controller;

		public int jumpCount = 2;
	
		void Update ()
		{
			position.x = speed*Input.GetAxis("Horizontal");
			position.y = jumpSpeed*Input.GetAxis("Vertical");

			if (!controller.isGrounded)
			{
				position.y -= gravity;
			}

			if (Input.GetButtonDown("Jump"))
			{
				position.y = jumpSpeed;
			}

			if (Input.GetButtonDown("Jump"))
			{
				jumpCount -= 1;
			}

			if (Input.GetButtonUp("Jump"))
			{
				position.y -= gravity;
			}
			//transform.Translate(position*Time.deltaTime);
			//position.y -= gravity;
			//position *= gravity;
			controller.Move(position * Time.deltaTime);
		}
	}
}
