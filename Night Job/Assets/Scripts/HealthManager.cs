﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour {

    public Image[] healtIndikator;
    public Sprite iconHealthFull;
    public Sprite iconHealthEmpty;

    public static int totalHealth;

    public GameObject overPanel;

    void Start()
    {
        totalHealth = 0;
    }

    void Update()
    {
        for (int i = 0; i < healtIndikator.Length; ++i)
        {
            if (i < totalHealth)
                healtIndikator[i].sprite = iconHealthEmpty;
            else
                healtIndikator[i].sprite = iconHealthFull;
        }
        if (totalHealth > 2)
        {
            Time.timeScale = 0;
            overPanel.SetActive(true);
        }
    }

    public static void OnChangeHealth()
    {
        totalHealth++;
    }

    public static void OnKurangHealth(){
        totalHealth--;
    }
}
