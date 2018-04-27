using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkorManager : MonoBehaviour {

    public static int skor;

    Text skorTeks;

	// Use this for initialization
	void Start () {
        skorTeks = GetComponent<Text>();
        skor = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (skor < 0)
        {
            skor = 0;
        }

        skorTeks.text = "" + skor;
    }

    public static void tambahSkor(int skorDitambahkan)
    {
        skor += skorDitambahkan;
    }
}
