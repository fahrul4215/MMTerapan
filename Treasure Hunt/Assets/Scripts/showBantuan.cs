using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showBantuan : MonoBehaviour {

    public GameObject panel;
    private float timeLeft;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            panel.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "hint")
        {
            panel.SetActive(true);
            timeLeft = 3;
        }
    }
}
