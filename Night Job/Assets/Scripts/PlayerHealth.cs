﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {
    
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Musuh"))
        {
            HealthManager.OnChangeHealth();
            Destroy(other.gameObject);
        }
    }
}
