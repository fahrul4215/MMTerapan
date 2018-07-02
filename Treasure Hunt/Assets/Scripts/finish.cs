using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finish : MonoBehaviour {

    public GameObject panel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "finish" && Input.GetAxis("Fire1") > 0)
        {
            Time.timeScale = 0;
            panel.SetActive(true);
        }
    }
}
