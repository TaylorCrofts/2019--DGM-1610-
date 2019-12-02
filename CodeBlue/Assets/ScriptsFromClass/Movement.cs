using System;
using System.Runtime.Remoting.Channels;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace ScriptsFromClass
{
	[RequireComponent(typeof(CharacterControllerScript2))]
	public class Movement : MonoBehaviour
	{
		public Vector3 position;
		public CharacterControllerScript2 controller;
		float isMoving = 0f;
		public float moveSpeed = 15f;
		public float gravity = 10f;
		public float jumpSpeed = 12f;
		private int _jumpCount;
		public int jumpCountMax = 2;
		private bool _jump = false;
		private bool _crouch = false;

		private void Start()
		{
			controller.Move(isMoving * Time.fixedDeltaTime, _crouch, _jump);
		}

		void Update()
		{

			isMoving = Input.GetAxisRaw("Horizontal") * moveSpeed;
		}

		void FixedUpdate()
		{
			if (Input.GetButtonDown("Jump"))
			{
				_jump = true;
			}

			if (Input.GetButtonDown("Crouch"))
			{
				_crouch = true;
			}else if (Input.GetButtonUp("Crouch"))
				_crouch = false;
			{
				
			}

			position.y -= gravity;
			if (controller.mGrounded)
			{
				position.y = 0;
				_jumpCount = 0;
			}

			if (Input.GetButtonDown("Jump") && _jumpCount < jumpCountMax)
			{
				position.y = jumpSpeed;
				_jumpCount++;
			}
		}
	}
}

	
