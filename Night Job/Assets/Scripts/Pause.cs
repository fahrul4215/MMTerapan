using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour {

	public GameObject pauseButton, pausePanel, overPanel;

	public void Start(){
		OnUnPause();
		overPanel.SetActive(false);
	}

	public void OnPause(){
		pausePanel.SetActive(true);
		pauseButton.SetActive(false);
		Time.timeScale = 0;
	}

	public void OnUnPause(){
		pausePanel.SetActive(false);
		pauseButton.SetActive(true);
		Time.timeScale = 1;
	}

	public void OnRestart(){
		Application.LoadLevel(Application.loadedLevel);
	}

	public void OnMenu(){
		Application.LoadLevel("Main Menu");
	}
}
