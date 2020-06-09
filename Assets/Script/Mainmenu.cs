using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void ToGame()
    {
        SceneManager.LoadScene("Kitchen");
    }

    public void ToSelect ()
    {
        SceneManager.LoadScene("Character");
    }
    public void tomenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void toinstruction()
    {
        SceneManager.LoadScene("Storyline");
    }
}
