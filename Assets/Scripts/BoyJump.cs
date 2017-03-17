using UnityEngine;
using System.Collections;

public class BoyJump : MonoBehaviour {


	public float m_JumpForce=600.0f;
	private Rigidbody2D m_Rigidbody2D;
	public float groundRadius = 0.2f;
	public Transform groundCheckBoy;
	public bool isGrounded;
	public LayerMask whatIsGround;

	void Awake()
	{
		m_Rigidbody2D = GetComponent<Rigidbody2D> ();
		groundCheckBoy= GameObject.Find ("GroundCheckBoy").transform;
	}

	void FixedUpdate()
	{
		isGrounded = Physics2D.OverlapCircle (groundCheckBoy.position, groundRadius, whatIsGround);
	}

	void Update () 
	{

		if (isGrounded && Input.GetButtonDown("Fire1")) 
		{
			m_Rigidbody2D.AddForce(new Vector2(0f, m_JumpForce));

		}

	}
}
