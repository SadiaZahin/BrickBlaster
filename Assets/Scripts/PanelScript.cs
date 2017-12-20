using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelScript : MonoBehaviour {
	public AudioSource clickButton;

    public void Retry()
    {
		clickButton.Play ();
        SceneManager.LoadScene("Minigame");
    }

	public void NextLevel()
	{
		clickButton.Play ();
		SceneManager.LoadScene("Level2");
	}

	public void MainMenu()
	{
		clickButton.Play ();
		SceneManager.LoadScene("MenuScreen");
	}

	public void Retry2()
	{
		clickButton.Play ();
		SceneManager.LoadScene("Level2");
	}

	public void NextLevel2()
	{
		clickButton.Play ();
		SceneManager.LoadScene("Level3");
	}
	public void Retry3()
	{
		clickButton.Play ();
		SceneManager.LoadScene("Level3");
	}


}
