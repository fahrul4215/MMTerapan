using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clone : MonoBehaviour {
    
    public GameObject musuh;

	// Use this for initialization
	void Start () {
        
	}

    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Musuh").Length <= 5)
        {
            Spawn();
        }
    }

    void Spawn()
    {
        float[] y = new float[] {2.3f, 0.6f, -1, -2.6f, -4.2f};
        Vector3 pos = new Vector2(Random.Range(5.25f, 7), y[Random.Range(0, y.Length)]);
        Instantiate(musuh, pos, transform.rotation);
    }
}
