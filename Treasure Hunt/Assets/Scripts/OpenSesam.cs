using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSesam : MonoBehaviour {

    public GameObject wall;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.tag == "Player" && Input.GetAxis("Fire1") > 0)
    //    {
    //        Destroy(wall);
    //    }
    //}

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && Input.GetAxis("Fire1") > 0)
        {
            Destroy(wall);
        }
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    //if (Input.GetAxis("Fire1") != 0)
    //    //{
    //    //    Destroy(wall);
    //    //}
    //    Destroy(wall);
    //}
}
