using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clone : MonoBehaviour {
    
    public GameObject time;
    public GameObject[] musuh;
    private Vector3 pos;
    public float delay = 0.25f;
    private float delayCounter;
    private int jumMusuh;

    TimeManager tm;

	// Use this for initialization
	void Start () {
        tm = time.GetComponent<TimeManager>();
        jumMusuh = 10;
	}

    void Update()
    {
        GameObject[] gos = GameObject.FindGameObjectsWithTag("Musuh");
        if (gos.Length <= jumMusuh)
        {
            float[] y = new float[] {2.3f, 0.6f, -1, -2.6f, -4.2f};
            pos = new Vector3(7, y[Random.Range(0, y.Length)]);
            delayCounter -= Time.deltaTime;
            if (delayCounter <= 0) 
            {
                delayCounter = delay;
                Instantiate(musuh[0], pos, transform.rotation);
            }
            if (tm.GetMenit() >= 1) 
            {
                Instantiate(musuh[1], pos, transform.rotation);                    
            }
            if (tm.GetMenit() >= 2) 
            {
                Instantiate(musuh[2], pos, transform.rotation);                    
                jumMusuh = 15;
            }
            if (tm.GetMenit() >= 4)
            {
                Instantiate(musuh[3], pos, transform.rotation);
                jumMusuh = 20;
            }
        }
    }
}
