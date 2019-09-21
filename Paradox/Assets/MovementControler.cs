using UnityEngine;

public class MovementControler : MonoBehaviour
{

	public int jumpcount;
	public float moveSpeed = 10f, gravity = 9.7f, jumpSpeed = 30f;
	private CharacterController controller;
	private Vector3 position;
	private int jumpCountMax = 2;
		
	// Use this for initialization
	void Start ()
	{
		controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		position.x = moveSpeed * Input.GetAxis("Horizontal");
		if (controller.isGrounded)
		{
			position.y = 0;
			jumpcount = 0;
		}

		if (Input.GetButtonDown("Jump") && jumpcount<jumpCountMax)
		{
			position.y = jumpSpeed;
			jumpcount++;
		}

		controller.Move(position * Time.deltaTime);
	}
}
