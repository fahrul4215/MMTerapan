using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour {

    public Image[] healtIndikator;
    public Sprite iconHealthFull;
    public Sprite iconHealthEmpty;

    public static int totalHealth;

    void Start()
    {
        totalHealth = 0;
    }

    void Update()
    {
        for (int i = 0; i < healtIndikator.Length; ++i)
        {
            if (i < totalHealth) healtIndikator[i].sprite = iconHealthEmpty;
            else healtIndikator[i].sprite = iconHealthFull;
        }
    }

    public static void OnChangeHealth()
    {
        if (totalHealth == 2)
        {
            Application.LoadLevel(0);
        }
        totalHealth++;
    }
}
