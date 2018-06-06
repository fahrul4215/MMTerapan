using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour {

    public GameObject door;
    public float rotasi;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            door.transform.rotation = Quaternion.Euler(0f, rotasi, 0f);
            MeshCollider coll = door.GetComponent<MeshCollider>();
            coll.isTrigger = false;
        }
    }
}
