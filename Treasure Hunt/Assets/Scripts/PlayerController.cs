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

	public Animator anim;
	public Transform pivot;
	public float rotateSpeed;

	public GameObject playerModel;

    public float knockBackForce;
    public float knockBackTime;
    private float knockBackCounter;

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

        if (knockBackCounter <= 0)
        {
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
        }
        else
        {
            knockBackCounter -= Time.deltaTime;
        }

		moveArah.y += (Physics.gravity.y * gravityScale * Time.deltaTime);
		controller.Move(moveArah * Time.deltaTime);

		// move player berbeda arah dari arahcamera
		if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0) 
		{
			transform.rotation = Quaternion.Euler(0f, pivot.rotation.eulerAngles.y, 0f);
			Quaternion newRotation = Quaternion.LookRotation(new Vector3(moveArah.x, 0f, moveArah.z));
			playerModel.transform.rotation = Quaternion.Slerp(playerModel.transform.rotation, newRotation, rotateSpeed * Time.deltaTime);
		}

		anim.SetBool("isGrounded", controller.isGrounded);
		anim.SetFloat("Speed", (Mathf.Abs(Input.GetAxis("Vertical")) + Mathf.Abs(Input.GetAxis("Horizontal"))));
	}

    public void KnockBack(Vector3 direction)
    {
        knockBackCounter = knockBackTime;

        moveArah = direction * knockBackForce;
        moveArah.y = knockBackForce;
    }
}
