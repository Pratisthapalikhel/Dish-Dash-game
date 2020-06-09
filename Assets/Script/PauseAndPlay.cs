using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class PauseAndPlay : MonoBehaviour {

    public bool pause;
	void Start () {
        pause = false;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void onPause()
    {
        pause = !pause;
        if(!pause)
        { Time.timeScale = 1;
        }
        else if (pause)
        {
            Time.timeScale = 0;

        }
    }
}
