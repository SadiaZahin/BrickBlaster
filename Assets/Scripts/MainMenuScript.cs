using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {
	public AudioSource clickB;

    public string mainGameScene; 
	public string HelpScene; 
	private int highScore;
	public string ScoreScene; 

	void start(){
		
	
	}
     
	public void Play()
    {
		PlayerPrefs.SetInt ("High Score", 0);

		clickB.Play();


        SceneManager.LoadScene(mainGameScene);
    }
    public void Score()
    {
		clickB.Play ();
		SceneManager.LoadScene(ScoreScene);
    }
    public void Settings()
    {
		clickB.Play ();
    }
    public void Help()
    {
		clickB.Play ();
		SceneManager.LoadScene(HelpScene);
    }

}
