using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BatonController : MonoBehaviour {

    public float speed;

    public float rotationSpeed;

    public GameObject go;

    // Use this for initialization
    void Start () {
        //UpdateSkorText();
    }
    
    // Update is called once per frame
    void Update () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
        GetComponent<Rigidbody2D>().angularVelocity = rotationSpeed;
        if (go.transform.position.x > 7)
        {
            Destroy(go);
        }
        // Debug.Log(go.transform.position.x);
	}
}
