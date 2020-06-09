using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountObjects : MonoBehaviour {
    public string nextLevel;
    public GameObject objToDestroy;
    GameObject objUI;
	// Use this for initialization
	void Start()
    {
        objUI = GameObject.Find("Soap");
    }
	// Update is called once per frame
	void Update () {
        objUI.GetComponent<Text>().text = miniscore.scoreCount.ToString();
        if (miniscore.scoreCount >= 5)
        {
            SceneManager.LoadScene("Game");
            //Destroy(objToDestroy);
            objUI.GetComponent<Text>().text = "All objects collected.";
        }

	}
}
