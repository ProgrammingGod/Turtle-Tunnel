﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {
	 
	public Text HighScoreLabel;
	private void Awake(){
		HighScoreLabel.text = " 1: " + PlayerPrefs.GetInt ("HS1") + "\n 2: " + PlayerPrefs.GetInt ("HS2")+ "\n 3: " + PlayerPrefs.GetInt ("HS3")+ "\n 4: " + PlayerPrefs.GetInt ("HS4")
			+ "\n 5: " + PlayerPrefs.GetInt ("HS5")+ "\n 6: " + PlayerPrefs.GetInt ("HS6")+ "\n 7: " + PlayerPrefs.GetInt ("HS7")+ "\n 8: " + PlayerPrefs.GetInt ("HS8")
			+ "\n 9: " + PlayerPrefs.GetInt ("HS9")+ "\n10: " + PlayerPrefs.GetInt ("HS10");
	}
}
