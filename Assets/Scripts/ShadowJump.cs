using UnityEngine;
using System.Collections;

public class ShadowJump : MonoBehaviour {


	public float s_JumpForce=-600.0f;
	private Rigidbody2D s_Rigidbody2D;
	public float groundRadius = 0.2f;
	public Transform groundCheckShadow;
	public bool grounded;
	public LayerMask whatIsGround;


	void Awake()

	{
		s_Rigidbody2D = GetComponent<Rigidbody2D> ();
		groundCheckShadow = GameObject.Find ("GroundCheckShadow").transform;
	}

	void FixedUpdate()
	{
		grounded = Physics2D.OverlapCircle (groundCheckShadow.position, groundRadius, whatIsGround);

	}

	void Update () 
	{

		if (grounded && Input.GetButtonDown("Fire2")) 
		{
			s_Rigidbody2D.AddForce(new Vector2(0f, s_JumpForce));

		}

	}



}
