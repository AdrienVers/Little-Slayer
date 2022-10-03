using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPBar : MonoBehaviour
{
    public Slider BarreHP;
    public int HP = 100;
    public Text TextHP;

    public GameObject Vivant;
    public GameObject Mort;
    public GameObject SansTete;
    public GameObject HPCanvas;
    public GameObject Arme;
    public GameObject Chrono;

    public float startYPos;
    public float endYPos;

    public bool isGrounded;
    public Transform groundCheckLeft;
    public Transform groundCheckRight;

    public float counter = 0;
    public float hit = 0;

    void Awake()
    {
        Vivant.SetActive(true);
        HPCanvas.SetActive(true);
        Chrono.SetActive(false);
        Mort.SetActive(false);

        GameObject.Find("Rouge").GetComponent<ChronoMove>().enabled = false;
    }

    void Start()
    {
        startYPos = gameObject.transform.position.y;
    }

    void FixedUpdate()
    {
        if (isGrounded)
        {
            endYPos = gameObject.transform.position.y;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Poison")
        {
            HP = HP - 10;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "BulletRocket") 
        {
            HP = HP - 20;

            //GameObject.Find("Bleu").GetComponent<Rigidbody2D>().freezeRotation = false; 
        }

        //if (other.gameObject.tag == "BulletRocket") { HP = HP - 20; }
        if (other.gameObject.tag == "BulletPompe") { HP = HP - 2; }
        if (other.gameObject.tag == "BulletSniper") { HP = HP - 10; }
        if (other.gameObject.tag == "Canne") { HP = HP - 15; }
        if (other.gameObject.tag == "Boomerang") { HP = HP - 5; }
        if (other.gameObject.tag == "Pot") { HP = HP - 1; }

        if (other.gameObject.tag == "BulletTourelle") 
        {
            counter += 1;
            if (counter == 5)
            {
                HP = HP - 1;
                counter = 0;
            }
        }

        if (other.gameObject.tag == "Homing") { HP = HP - 20; }
        if (other.gameObject.tag == "Mine") { HP = HP - 10; }
        if (other.gameObject.tag == "Snake") { HP = HP - 10; }
        if (other.gameObject.tag == "Shark") { HP = HP - 100; }

        if (other.gameObject.tag == "Arrow") { HP = HP - 15; }
        if (other.gameObject.tag == "Shuriken") { HP = HP - 10; }

        //if (other.gameObject.tag == "CouteauHandle") { HP = HP - 5; }
        if (other.gameObject.tag == "NuclearBomb") { HP = HP - 90; }


        if (40 > startYPos - endYPos && startYPos - endYPos >= 30)
        {
            HP = HP - 50;
            startYPos = 0;
            endYPos = 0;
        }


        else if (30 > startYPos - endYPos && startYPos - endYPos >= 20)
        {
            HP = HP - 40;
            startYPos = 0;
            endYPos = 0;
        }

        else if (20 > startYPos - endYPos && startYPos - endYPos >= 15)
        {
            HP = HP - 30;
            startYPos = 0;
            endYPos = 0;
        }

        else if (15 > startYPos - endYPos && startYPos - endYPos >= 10)
        {
            HP = HP - 20;
            startYPos = 0;
            endYPos = 0;
        }

        else if (10 > startYPos - endYPos && startYPos - endYPos >= 5)
        {
            HP = HP - 10;
            startYPos = 0;
            endYPos = 0;
        }


        if (other.gameObject.tag == "Health") { HP = HP + 50; }
    }

    public void Update()
    {
        isGrounded = Physics2D.OverlapArea(groundCheckLeft.position, groundCheckRight.position); // création d'une ligne de collision

        BarreHP.value = HP;

        //if (GetComponentInChildren<HPDetection>().Detected == true && Grenade.GetComponentInChildren<GrenadeTimer>().currentTime == 0) { HP = HP - 30; };

        if (HP > 100)
        {
            HP = 100;
        }

        if (HP < 0)
        {
            HP = 0;
        }

        TextHP.text = HP.ToString();

        /*
        if (GetComponentInChildren<ChronoMove>().reset == true)
        {
            GameObject.Find("Rouge").GetComponent<ChronoMove>().enabled = false;
        }
        */

        if (HP == 0)
        {
            Chrono.SetActive(true);

            if (GetComponentInChildren<MortTimer>().currentTime == 0)
            {
                Vivant.SetActive(false);
                HPCanvas.SetActive(false);
                Chrono.SetActive(false);
                Arme.SetActive(false);
                Mort.SetActive(true);
            }
        }

    }
}
