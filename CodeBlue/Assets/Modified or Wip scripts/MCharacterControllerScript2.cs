using UnityEngine;
using UnityEngine.Events;

namespace Modified_or_Wip_scripts
{
	[RequireComponent(typeof(Collider))]
	public class MCharacterControllerScript2 : MonoBehaviour
	{
		[SerializeField] private float mJumpForce = 400f;							// Amount of force added when the player jumps.
		[Range(0, 1)] [SerializeField] private float mCrouchSpeed = .36f;			// Amount of maxSpeed applied to crouching movement. 1 = 100%
		[Range(0, .3f)] [SerializeField] private float mMovementSmoothing = .05f;	// How much to smooth out the movement
		[SerializeField] private bool mAirControl;									// Whether or not a player can steer while jumping;
		[SerializeField] private LayerMask mWhatIsGround;							// A mask determining what is ground to the character
		[SerializeField] private Transform mGroundCheck;							// A position marking where to check if the player is grounded.
		[SerializeField] private Transform mCeilingCheck;							// A position marking where to check for ceilings
		[SerializeField] private Collider mCrouchDisableCollider;					// A collider that will be disabled when crouching
		const float KGroundedRadius = .2f; 										// Radius of the overlap circle to determine if grounded
		public bool mGrounded;            											// Whether or not the player is grounded.
		const float KCeilingRadius = .2f; 											// Radius of the overlap circle to determine if the player can stand up
		private Rigidbody _mRigidbody;
		private bool _mFacingRight = true;  										// For determining which way the player is currently facing.
		private Vector3 _mVelocity = Vector3.zero;

		[Header("Events")]
		[Space]

		public UnityEvent onLandEvent;

		[System.Serializable]
		public class BoolEvent : UnityEvent<bool> { }

		public BoolEvent onCrouchEvent;
		private bool _mWasCrouching;

		private void Awake()
		{
			_mRigidbody = GetComponent<Rigidbody>();
			GetComponent<Collider>();

			if (onLandEvent == null)
				onLandEvent = new UnityEvent();

			if (onCrouchEvent == null)
				onCrouchEvent = new BoolEvent();
		}

		private void FixedUpdate()
		{
			bool wasGrounded = mGrounded;

			// The player is grounded if a circlecast to the groundcheck position hits anything designated as ground
			// This can be done using layers instead but Sample Assets will not overwrite your project settings.
			//Collider[] colliers = Physics.OverlapCircleAll(m_GroundCheck.position, k_GroundedRadius, m_WhatIsGround)
			//for (int i = 0; i < colliers.Length; i++)
			//{
			//if (GetComponent<Collider>().gameObject != gameObject)
			//{
			mGrounded = true;
			if (!wasGrounded) 
				onLandEvent.Invoke(); 
		}



		public void Move(float move, bool crouch, bool jump)
		{
			// If crouching, check to see if the character can stand up
			if (!crouch)
			{
				// If the character has a ceiling preventing them from standing up, keep them crouching
				if (Physics2D.OverlapCircle(point: mCeilingCheck.position, radius: KCeilingRadius, layerMask: mWhatIsGround))
				{
					crouch = true;
				}
			}

			//only control the player if grounded or airControl is turned on
			if (mGrounded || mAirControl)
			{

				// If crouching
				if (crouch)
				{
					if (!_mWasCrouching)
					{
						_mWasCrouching = true;
						onCrouchEvent.Invoke(arg0: true);
					}

					// Reduce the speed by the crouchSpeed multiplier
					move *= mCrouchSpeed;

					// Disable one of the colliders when crouching
					if (mCrouchDisableCollider != null)
						mCrouchDisableCollider.enabled = false;
				} else
				{
					// Enable the collider when not crouching
					if (mCrouchDisableCollider != null)
						mCrouchDisableCollider.enabled = true;

					if (_mWasCrouching)
					{
						_mWasCrouching = false;
						onCrouchEvent.Invoke(arg0: false);
					}
				}

				// Move the character by finding the target velocity
				var velocity = _mRigidbody.velocity;
				Vector3 target = new Vector2(x: move * 10f, y: velocity.y);
				// And then smoothing it out and applying it to the character
				_mRigidbody.velocity = Vector3.SmoothDamp(current: velocity, target: target, currentVelocity: ref _mVelocity, smoothTime: mMovementSmoothing);

				// If the input is moving the player right and the player is facing left...
				if (move > 0 && !_mFacingRight)
				{
					// ... flip the player.
					Flip();
				}
				// Otherwise if the input is moving the player left and the player is facing right...
				else if (move < 0 && _mFacingRight)
				{
					// ... flip the player.
					Flip();
				}
			}
			// If the player should jump...
			if (mGrounded && jump)
			{
				// Add a vertical force to the player.
				mGrounded = false;
				_mRigidbody.AddForce(force: new Vector2(x: 0f, y: mJumpForce));
			}
		}


		private void Flip()
		{
			// Switch the way the player is labelled as facing.
			_mFacingRight = !_mFacingRight;

			// Multiply the player's x local scale by -1.
			var transform1 = transform;
			Vector3 theScale = transform1.localScale;
			theScale.x *= -1;
			transform1.localScale = theScale;
		}
	}
}
