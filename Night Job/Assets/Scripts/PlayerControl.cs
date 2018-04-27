using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour
{
    public Transform firepoint;
    public GameObject baton;

    public float shotDelay;
    private float shotDelayCounter;

    void Update()
	{
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
