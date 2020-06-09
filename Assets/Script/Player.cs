using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {
	public float speed = 5f;
	private float jump = 8f;
	private float gravity = 20f;
	private float fallM = 3f;
	private Vector3 moveDir = Vector3.zero;
	private CharacterController controller;
    public AudioSource catfood;
    public AudioSource collision;

    [SerializeField]
	GameObject win;

	void Start () {
		controller =GetComponent<CharacterController> ();
	
	}


	void Update () {
		//CharacterController controller = gameObject.GetComponent<CharacterController> ();
		if (controller.isGrounded) {
			moveDir = new Vector3 (0, 0, -(Input.GetAxis ("Horizontal")));
		
			moveDir = transform.TransformDirection (moveDir);

			moveDir *= speed;

			if (Input.GetButtonDown ("Jump")) {
				moveDir.y = jump;
			}
		}

		moveDir.y -= gravity * Time.deltaTime;

		controller.Move (moveDir * Time.deltaTime);

	}
  

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "point")
        {
            score.scoreValue += 1;
            Destroy(col.gameObject);
            catfood.Play();
            GameObject _win = Instantiate(win) as GameObject;
            _win.transform.position = this.transform.position;
            Destroy(_win, 1f);
        }
        if (col.gameObject.tag == "obstacle")
        {
            SceneManager.LoadScene("minigame");
        }
    }
}