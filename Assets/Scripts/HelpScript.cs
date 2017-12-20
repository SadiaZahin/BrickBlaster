using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HelpScript : MonoBehaviour {
	public AudioSource clickB;

	public string MenuScene; 


	public void BackToMenu()
	{
		clickB.Play();
		SceneManager.LoadScene(MenuScene);
	}


}
