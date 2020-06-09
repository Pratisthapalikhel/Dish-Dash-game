using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {

    public static int scoreValue = 0;
	Text scores;
    public Text scoreText;
    public Deathmenu deathmenu;



    private bool isDead = false;

	// Use this for initialization
	void Start () {
		scores = GetComponent<Text> ();
    }
	
	// Update is called once per frame
	void Update () {
        if (isDead)
            return;

        scores.text = "Score:" + scoreValue; 
		
	}
    public void OnDeath()
    {
        isDead = true;
        PlayerPrefs.SetFloat("HighScore", scoreValue);
        deathmenu.ToggleEndMenu(scoreValue);
    }


}
