using Modified_or_Wip_scripts;
using UnityEngine;

	[RequireComponent(typeof(MCharacterControllerScript2))]
	public class MMovement : MonoBehaviour
	{
		private Vector3 _position;
		public MCharacterControllerScript2 controller;
		private float _isMoving;
		public float moveSpeed = 15f;
		private int _jumpCount;
		public int jumpCountMax = 3;
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
				_jumpCount++;
				_jump = true;
			}

			if (Input.GetButtonDown("Crouch"))
			{
				_crouch = true;
			}
			else if (Input.GetButtonUp("Crouch"))
				_crouch = false;
		}

	}
	


	
