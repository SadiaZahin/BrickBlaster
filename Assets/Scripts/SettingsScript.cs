using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsScript : MonoBehaviour {


	public int lang;

	// Use this for initialization
	void bangla () {
		lang = 1;
		PlayerPrefs.SetInt ("language", lang);
	}
	
	// Update is called once per frame
	void english () {
		lang = 0;
		PlayerPrefs.SetInt ("language", lang);
	}
}
