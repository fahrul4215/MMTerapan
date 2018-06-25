using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusuhSerang : MonoBehaviour {

	public Image[] hatiImage;
    public Sprite iconHatiKosong;
    public Sprite iconHatiIsi;

    public void OnChangeStarTotal(int skorTotal) {
        for (int i = 0; i < hatiImage.Length; ++i) {
            if (i < skorTotal) hatiImage[i].sprite = iconHatiKosong;
            else hatiImage[i].sprite = iconHatiIsi;
        }
    }
}
