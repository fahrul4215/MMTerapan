using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour {

	public Text timeCounter;

	public float second, menit;

	// Use this for initialization
	void Start () {
		timeCounter = GetComponent<Text>() as Text;
	}
	
	// Update is called once per frame
	void Update () {
		menit = (int)(Time.timeSinceLevelLoad/60f);
		second = (int)(Time.timeSinceLevelLoad%60f);
		timeCounter.text = menit.ToString("00")+":"+second.ToString("00");
	}

	public float GetMenit(){
		return menit;
	}
}
