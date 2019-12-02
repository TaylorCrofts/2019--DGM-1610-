using UnityEngine;
namespace ScriptsFromClass
{
	[RequireComponent(typeof(CharacterControllerScript2))]
	public class Movement : MonoBehaviour
	{
		private Vector3 _position;
		public CharacterControllerScript2 controller;
		private float _isMoving;
		public float moveSpeed = 15f;
		public float gravity = 10f;
		public float jumpSpeed = 12f;
		private int _jumpCount;
		public int jumpCountMax = 2;
		private bool _jump;
		private bool _crouch;

		private void Start()
		{
			controller.Move(_isMoving * Time.fixedDeltaTime, _crouch, _jump);
		}

		void Update()
		{

			_isMoving = Input.GetAxisRaw("Horizontal") * moveSpeed;
		}

		void FixedUpdate()
		{
			if (Input.GetButtonDown("Jump") && _jumpCount < jumpCountMax)
			{
            				_position.y = jumpSpeed;
            				_jumpCount++;
			}
			{
				
				_jump = true;
			}

			if (Input.GetButtonDown("Crouch"))
			{
				_crouch = true;
			}else if (Input.GetButtonUp("Crouch"))
				_crouch = false;
			

			_position.y -= gravity;
			if (controller.mGrounded)
			{
				_position.y = 0;
				_jumpCount = 0;
			}
			
		}
	}
}

	
