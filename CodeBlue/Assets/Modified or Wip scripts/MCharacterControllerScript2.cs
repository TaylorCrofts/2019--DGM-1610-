using UnityEngine;
using UnityEngine.Events;

namespace Modified_or_Wip_scripts
{
	[RequireComponent(typeof(Collider))]
	public class MCharacterControllerScript2 : MonoBehaviour
	{
		[SerializeField] private float mJumpForce = 400f;							
		[Range(0, 1)] [SerializeField] private float mCrouchSpeed = .36f;			 
		[Range(0, .3f)] [SerializeField] private float mMovementSmoothing = .05f;	
		[SerializeField] private bool mAirControl;									
		[SerializeField] private LayerMask mWhatIsGround;							
		[SerializeField] private Transform mGroundCheck;							
		[SerializeField] private Transform mCeilingCheck;							
		[SerializeField] private Collider mCrouchDisableCollider;
		public bool mGrounded;            											
		const float KCeilingRadius = .2f; 											
		private Rigidbody _mRigidbody;
		private bool _mFacingRight = true;  										
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
			
			mGrounded = true;
			if (!wasGrounded) 
				onLandEvent.Invoke(); 
		}



		public void Move(float move, bool crouch, bool jump)
		{
			if (!crouch)
			{
				if (Physics2D.OverlapCircle(point: mCeilingCheck.position, radius: KCeilingRadius, layerMask: mWhatIsGround))
				{
					crouch = true;
				}
			}
			
			if (mGrounded || mAirControl)
			{
				if (crouch)
				{
					if (!_mWasCrouching)
					{
						_mWasCrouching = true;
						onCrouchEvent.Invoke(arg0: true);
					}
					
					move *= mCrouchSpeed;
					
					if (mCrouchDisableCollider != null)
						mCrouchDisableCollider.enabled = false;
				} else
				{
					if (mCrouchDisableCollider != null)
						mCrouchDisableCollider.enabled = true;

					if (_mWasCrouching)
					{
						_mWasCrouching = false;
						onCrouchEvent.Invoke(arg0: false);
					}
				}
				
				var velocity = _mRigidbody.velocity;
				Vector3 target = new Vector2(x: move * 10f, y: velocity.y);
				_mRigidbody.velocity = Vector3.SmoothDamp(current: velocity, target: target, currentVelocity: ref _mVelocity, smoothTime: mMovementSmoothing);
				if (move > 0 && !_mFacingRight)
				{
					
					Flip();
				}
				
				else if (move < 0 && _mFacingRight)
				{
				
					Flip();
				}
			}
			
			if (mGrounded && jump)
			{
				
				mGrounded = false;
				_mRigidbody.AddForce(force: new Vector2(x: 0f, y: mJumpForce));
			}
		}


		private void Flip()
		{
			
			_mFacingRight = !_mFacingRight;
			
			var transform1 = transform;
			Vector3 theScale = transform1.localScale;
			theScale.x *= -1;
			transform1.localScale = theScale;
		}
	}
}
