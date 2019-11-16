using UnityEngine;

namespace ScriptsFromClass
{
	[RequireComponent(typeof(CharacterController))]
	public class Movement : MonoBehaviour
	{
		private Vector3 position;
		private CharacterController controller;

		public float moveSpeed = 15f;
		public float gravity = 10f;
		public float jumpspeed = 12f;
		private int jumpCount;
		public int jumpCountMax = 2;

		void Start()
		{
			controller = GetComponent<CharacterController>();
		}

		void Update()
		{
			position.x = moveSpeed * Input.GetAxis("Horizontal");
			position.y -= gravity;
			if (controller.isGrounded)
			{
				position.y = 0;
				jumpCount = 0;
			}

			if (Input.GetButtonDown("Jump")&& jumpCount<jumpCountMax)
			{
				position.y = jumpspeed;
				jumpCount++;
			}

			controller.Move(position * Time.deltaTime);
		}
	}
}
	
