using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class miniplayer : MonoBehaviour
{
    private Rigidbody rb;
    private bool ismovingright = false;
    [HideInInspector]
    public bool canmove = true;
    public static int count;
    private bool isDead = false;
    public GameObject mini_player;

    public AudioSource deathSong;
    public AudioSource collect;




    [SerializeField]
    float speed = 4f;

    [SerializeField]
    GameObject Bubbles;

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        count = 0;


    }
    void Update()
    {

        if (isDead)
            return;
        mini_player = GameObject.FindWithTag("miniplayer");

        if (mini_player.transform.position.y < 0)
        {
            Death();
            deathSong.Play();
        }

        if (Input.GetMouseButtonDown(0) && canmove)
        {
            ChangeBoolean();
            ChangeDirection();
        }

        if (Physics.Raycast(this.transform.position, Vector3.down * 2) == false)
        {
            FallDown();


        }

    }

    private void FallDown()
    {
        canmove = false;
        rb.velocity = new Vector3(0, -1f, 0f);

    }

    private void Death()
    {
        Debug.Log("dead");
        isDead = true;
        GetComponent<score>().OnDeath();


    }

    private void ChangeBoolean()
    {
        ismovingright = !ismovingright;


    }

    private void ChangeDirection()
    {
        if (ismovingright)
        {
            rb.velocity = new Vector3(speed, 0f, 0f);
        }

        else
        {
            rb.velocity = new Vector3(0f, 0f, speed);
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Soap")
        {
            miniscore.scoreCount += 1;
            count = count + 1;
            Destroy(col.gameObject);
            collect.Play();
            if (count >= 5)
            {
                SceneManager.LoadScene("Kitchen");
                miniscore.scoreCount = 0;
                count = 0;

            }

            GameObject _bubbles = Instantiate(Bubbles) as GameObject;
            _bubbles.transform.position = this.transform.position;
            Destroy(_bubbles, 1f);


        }
    }

}

