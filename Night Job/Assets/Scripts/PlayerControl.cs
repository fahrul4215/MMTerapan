using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour
{
    public Transform firepoint;
    public GameObject baton;

    public float shotDelay;
    private float shotDelayCounter;

    private Rigidbody2D rigidbody2D;
    private Animator anim;

    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
	{
        if (Time.timeScale > 0) 
        {
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
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(baton, firepoint.position, firepoint.rotation);
                shotDelayCounter = shotDelay;
            }

            if (Input.GetKey(KeyCode.Space))
            {
                shotDelayCounter -= Time.deltaTime;

                if (shotDelayCounter <= 0)
                {
                    shotDelayCounter = shotDelay;
                    Instantiate(baton, firepoint.position, firepoint.rotation);
                }
            }
        }
	}

}
