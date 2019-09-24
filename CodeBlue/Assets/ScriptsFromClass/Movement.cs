using System;
using JetBrains.Annotations;
using UnityEngine;

namespace ScriptsFromClass
{
	public class Movement : MonoBehaviour
	{
		
		public float speed = 7.1f;
		public float gravity = 10.2f;
		public float jumpSpeed = -1.1f;
		public int jumpCount = 2;
		public int jumpCountMax = 2;
	
		public Vector3 position;
		public CharacterController controller;

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

			if (Input.GetButtonUp("Jump"))
			{
				position.y -= gravity;
			}

			if (controller.isGrounded)
			{
				position.y = 0;
				jumpCount = 0;
			}

			if (Input.GetButtonDown("Jump")&& jumpCount < jumpCountMax)
			{
				position.y = jumpSpeed;
				jumpCount++;
			}
			//(++)-Means +1
			//transform.Translate(position*Time.deltaTime);
			//position.y -= gravity;
			//position *= gravity;
			controller.Move(position * Time.deltaTime);
		}
	}
}
