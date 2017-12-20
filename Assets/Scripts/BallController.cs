using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour {
	public float speed;
    public Text countText;
	private Rigidbody rb;
    private int count;
    public Text winText;
    public AudioSource rollAudio;
    public AudioSource crashAudio;
	//public AudioSource passAudio;
	public AudioSource levelAudio;
    public float timeDuration;
    public GameObject panelPASS;
	public GameObject panelFAIL;
	public int pickUpCount;
	private int highScore, score;

	public int level;

    
	void Start()
	{
		

        panelPASS.gameObject.SetActive(false);
		panelFAIL.gameObject.SetActive (false);
		rb = GetComponent<Rigidbody> ();
        count = 0;
        
        winText.text = "";


    }

    /*void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}*/

	void Update()
    {
		
    }



    void OnTriggerEnter(Collider other)
    {

		Debug.Log ("Trigger");
        if(other.gameObject.CompareTag("Pick Up"))
        {
            crashAudio.Play();
            other.gameObject.SetActive(false);
            count++;
            setCountText();


        }

		if (other.gameObject.CompareTag ("Wall")) {

			Debug.Log ("Touched the wall");
			if (panelPASS.gameObject.activeSelf==false) {
				levelAudio.Stop();
				panelFAIL.gameObject.SetActive (true);


			}
		}




    }

    void setCountText()
    {

		score = PlayerPrefs.GetInt("Score");
        countText.text = "Score: " + count.ToString();
		countText.fontSize = 35;
		if (count == pickUpCount)
        {
				levelAudio.Stop();
			if (level == 1) {
				score = 1;
			}
			else if (level == 2) {
				score = 3;
			}
			else if (level == 3) {
				score = 5;
			}
			//score = score + pickUpCount;
			PlayerPrefs.SetInt ("Score", score);
 			//passAudio.Play ();






			float timer = 0;
			while (timer < 300) {
				timer++;
			}


			highScore = PlayerPrefs.GetInt("High Score");

			if (highScore < score) {
				highScore = score;
				PlayerPrefs.SetInt ("High Score", highScore);
			}


			panelPASS.gameObject.SetActive (true);

        }


       
    }
    

    public void jump(float x, float y)
    {
		Handheld.Vibrate ();
        rollAudio.Play();
        timeDuration = 0;
        Vector3 movement = new Vector3(x, 0.0f, y);
        rb.AddForce(movement * speed);

        Debug.Log("mve");


     }

    
}
