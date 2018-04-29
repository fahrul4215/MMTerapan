using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuActions : MonoBehaviour {
	
	public string sceneName;

    public void GameStart()
    {
        Application.LoadLevel(sceneName);
    }

    public void QuitGame(){
    	Application.Quit();
    }
}
