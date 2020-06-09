using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class miniscore : MonoBehaviour {

	public static int scoreCount = 0;
	public Text scores;
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

        scores.text = (scoreCount).ToString();
    }

    public void OnDeath()
    {
        isDead = true;
        PlayerPrefs.SetFloat("HighScore", score.scoreValue);
        deathmenu.ToggleEndMenu(score.scoreValue);
    }
}
