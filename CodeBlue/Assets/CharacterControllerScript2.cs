using UnityEngine;
using UnityEngine.Events;
[RequireComponent(typeof(Collider))]
public class CharacterControllerScript2 : MonoBehaviour
{
	//[SerializeField] private float mJumpForce = 400f;							// Amount of force added when the player jumps.
	[Range(0, 1)] [SerializeField] private float mCrouchSpeed = .36f;			// Amount of maxSpeed applied to crouching movement. 1 = 100%
	[Range(0, .3f)] [SerializeField] private float mMovementSmoothing = .05f;	// How much to smooth out the movement
	[SerializeField] private bool mAirControl = false;							// Whether or not a player can steer while jumping;
	[SerializeField] private LayerMask mWhatIsGround;							// A mask determining what is ground to the character
	[SerializeField] private Transform mGroundCheck;							// A position marking where to check if the player is grounded.
	[SerializeField] private Transform mCeilingCheck;							// A position marking where to check for ceilings
	[SerializeField] private Collider mCrouchDisableCollider;				// A collider that will be disabled when crouching
	private Vector3 position;
	const float kGroundedRadius = .2f; // Radius of the overlap circle to determine if grounded
	public bool mGrounded;            // Whether or not the player is grounded.
	const float kCeilingRadius = .2f; // Radius of the overlap circle to determine if the player can stand up
	private Rigidbody mRigidbody;
	private bool mFacingRight = true;  // For determining which way the player is currently facing.
	//private Vector3 mVelocity = Vector3.zero;

	[Header("Events")]
	[Space]

	public UnityEvent onLandEvent;

	[System.Serializable]
	public class BoolEvent : UnityEvent<bool> { }

	public BoolEvent onCrouchEvent;
	private bool mwasCrouching = false;

	private void Awake()
	{
		mRigidbody = GetComponent<Rigidbody>();
		GetComponent<Collider>();

		if (onLandEvent == null)
			onLandEvent = new UnityEvent();

		if (onCrouchEvent == null)
			onCrouchEvent = new BoolEvent();
	}

	private void FixedUpdate()
	{
		bool wasGrounded = mGrounded;
		mGrounded = false;

		// The player is grounded if a circlecast to the groundcheck position hits anything designated as ground
		// This can be done using layers instead but Sample Assets will not overwrite your project settings.
		 Collider[] colliders = Physics.OverlapCapsule(position , position , kGroundedRadius, mWhatIsGround);
		 for (int i = 0; i < colliders.Length; i++)
		{
			if (GetComponent<Collider>().gameObject != gameObject)
			{
				mGrounded = true;
				if (!wasGrounded)
					onLandEvent.Invoke();
			}
		}
	}


	public void Move(float move, bool crouch, bool jump)
	{
		// If crouching, check to see if the character can stand up
		if (!crouch)
		{
			// If the character has a ceiling preventing them from standing up, keep them crouching
			if (Physics2D.OverlapCircle(mCeilingCheck.position, kCeilingRadius, mWhatIsGround))
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
				if (!mwasCrouching)
				{
					mwasCrouching = true;
					onCrouchEvent.Invoke(true);
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

				if (mwasCrouching)
				{
					mwasCrouching = false;
					onCrouchEvent.Invoke(false);
				}
			}

			// Move the character by finding the target velocity
			//Vector3 position = new Vector2(move * 10f, mRigidbody.velocity.y);
			// And then smoothing it out and applying it to the character
			//mRigidbody.velocity = Vector3.SmoothDamp(mRigidbody.velocity, position, ref mVelocity, mMovementSmoothing);

			// If the input is moving the player right and the player is facing left...
			if (move > 0 && !mFacingRight)
			{
				// ... flip the player.
				Flip();
			}
			// Otherwise if the input is moving the player left and the player is facing right...
			else if (move < 0 && mFacingRight)
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
		//	mRigidbody.AddForce(new Vector2(0f, mJumpForce));
		}
	}


	private void Flip()
	{
		// Switch the way the player is labelled as facing.
		mFacingRight = !mFacingRight;

		// Multiply the player's x local scale by -1.
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
