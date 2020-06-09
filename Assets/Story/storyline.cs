using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class storyline : MonoBehaviour {

    [TextArea (4,30)]
    public string[] page;
    int pageNumber = -1;
    Text view;

	void Start () {

        view = GetComponent<Text>();
        Invoke("PageTurn", 2);


	}
	
	// Update is called once per frame
	void PageTurn () {
        pageNumber = pageNumber+1 ;

        if (pageNumber < page.Length)
        { view.text = page[pageNumber];
            Invoke("PageTurn", 2);
        }
    }
    public void ToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
