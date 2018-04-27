using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
    // public float speed = 10;
    private Rigidbody2D rigidbody2D;
    private Animator anim;

    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // float xMove = Input.GetAxis("Horizontal");
        // float yMove = Input.GetAxis("Vertical");
        // float xSpeed = xMove * speed;
        // float ySpeed = yMove * speed;
        // Vector2 newVelocity = new Vector2(xSpeed, ySpeed);
        // rigidbody2D.velocity = newVelocity;

        // if (Input.GetKeyDown(KeyCode.LeftArrow)) {
        //     anim.SetTrigger("mlaku");
        //     Vector3 position = this.transform.position;
        //     position.x--;
        //     this.transform.position = position;
        // }else if (Input.GetKeyDown(KeyCode.RightArrow)) {
        //     anim.SetTrigger("mlaku");
        //     Vector3 position = this.transform.position;
        //     position.x++;
        //     this.transform.position = position;
        // }else
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) {
            Vector3 position = this.transform.position;
            if (position.y < 1) 
            {
                anim.SetTrigger("mlaku");
                position.y+=1.6f;
                this.transform.position = position;
            }
        }else if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S)) {
            Vector3 position = this.transform.position;
            if (position.y > -4)
            {
                anim.SetTrigger("mlaku");
                position.y-=1.6f;
                this.transform.position = position;
            }
        }
    }
}
