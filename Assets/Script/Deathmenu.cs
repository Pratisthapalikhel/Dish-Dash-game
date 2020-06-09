using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Deathmenu : MonoBehaviour {

    public Text scoreText;
    public Image backgroundImg;
    public static int scoreValue = 0;

    private bool isShowned = false;

    private float transition=0.0f;
	// Use this for initialization
	void Start () {

        gameObject.SetActive (false);
		
	}
	
	// Update is called once per frame
	void Update () {
        if ( !isShowned)
            return;

        transition += Time.deltaTime;
        backgroundImg.color = Color.Lerp(new Color(0, 0, 0, 0), Color.black, transition);

		
	}

    public void ToggleEndMenu(float score) {
        gameObject.SetActive(true);
        scoreText.text = (scoreValue).ToString();
        isShowned = true;
    }

    public void Restart()
    {
        SceneManager.LoadScene("Kitchen");
        score.scoreValue = 0;

    }
    public void tomenu()
    {
        SceneManager.LoadScene("Menu");
    }

}
