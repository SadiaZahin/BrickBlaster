using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HighScoreScript : MonoBehaviour {

	// Use this for initialization
	private int highScore;
	public AudioSource zeroAudio;
	public AudioSource oneAudio;
	public AudioSource threeAudio;
	public AudioSource fiveAudio;
	public string MenuScene; 
	public AudioSource clickB;




	void Start () {
		highScore = PlayerPrefs.GetInt("High Score");

		Debug.Log (highScore);

		if (highScore == 0) {
			zeroAudio.Play ();

		} else if (highScore == 1) {
			oneAudio.Play ();
		}
		else if (highScore == 3) {
			threeAudio.Play ();
		}
		else if (highScore == 5) {
			fiveAudio.Play ();
		}
			
			

	}

	public void BackToMenu()
	{
		clickB.Play();
		SceneManager.LoadScene(MenuScene);
	}


	
	// Update is called once per frame
	void Update () {
		
	}
}
