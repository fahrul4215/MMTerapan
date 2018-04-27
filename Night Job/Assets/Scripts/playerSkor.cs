using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerSkor : MonoBehaviour {

	public Text skorText;
	private int totalSkor = 0;

	void Start()
	{
		UpdateSkorText();
	}

	void OnTriggerEnter2D(Collider2D hit)
	{
		if (hit.CompareTag("Musuh"))
		{
			totalSkor++;
			UpdateSkorText();
			Destroy(hit.gameObject);
		}
	}

	private void UpdateSkorText()
	{
		string skorMessage = "Skor : " + totalSkor;
		skorText.text = skorMessage;
	}
}
