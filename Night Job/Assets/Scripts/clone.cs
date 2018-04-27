using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clone : MonoBehaviour {

    public float spawnTime = 2f;
    public float spawnDelay = 1f;
    public GameObject musuh;

	// Use this for initialization
	void Start () {
        InvokeRepeating("Spawn", spawnDelay, spawnTime);
	}
	
    void Spawn()
    {
        Vector2 pos = new Vector2(Random.Range(-7, 7), Random.Range(-5, 5));
        Instantiate(musuh, pos, transform.rotation);
    }
}
