using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float moveSpeed;
	// public Rigidbody rigid;
	public float jumpForce;
	public CharacterController controller;

	private Vector3 moveArah;
	public float gravityScale;

	// Use this for initialization
	void Start () {
		// rigid = GetComponent<Rigidbody>();
		controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		// rigid.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, rigid.velocity.y, Input.GetAxis("Vertical") * moveSpeed);

		// if (Input.GetButtonDown("Jump")) 
		// {
		// 	rigid.velocity = new Vector3(rigid.velocity.x, jumpForce, rigid.velocity.z);
		// }

		// moveArah = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, moveArah.y, Input.GetAxis("Vertical") * moveSpeed);
		float yStore = moveArah.y;
		moveArah = (transform.forward * Input.GetAxis("Vertical")) + (transform.right * Input.GetAxis("Horizontal"));
		moveArah = moveArah.normalized * moveSpeed;
		moveArah.y = yStore;

		if (controller.isGrounded)
		{
			moveArah.y = 0f;
			if (Input.GetButtonDown("Jump")) 
			{
				moveArah.y = jumpForce;
			}
		}

		moveArah.y += (Physics.gravity.y * gravityScale * Time.deltaTime);
		controller.Move(moveArah * Time.deltaTime);
	}
}
