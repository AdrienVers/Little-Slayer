using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quadriformation : MonoBehaviour
{
    public GameObject Vivant;
    public GameObject Mort1;
    public GameObject Mort2;
    public GameObject Mort3;
    public GameObject Mort4;
    //public GameObject Chrono;

    public bool hasHit = false;

    void Awake()
    {
        Vivant.SetActive(true);
        //Chrono.SetActive(false);
        Mort1.SetActive(false);
        Mort2.SetActive(false);
        Mort3.SetActive(false);
        Mort4.SetActive(false);
    }

    void Update()
    {
        if (hasHit == true)
        {

            Vivant.SetActive(false);
            Mort1.SetActive(true);
            Mort2.SetActive(true);
            Mort3.SetActive(true);
            Mort4.SetActive(true);

            //GetComponent<PolygonCollider2D>().enabled = false;
            //GetComponent<Rigidbody2D>().gravityScale = 1;

            /*
            Chrono.SetActive(true);

            if (GetComponentInChildren<MortTimer>().currentTime == 0)
            {
                Vivant.SetActive(false);
                //Chrono.SetActive(false);
                Mort.SetActive(true);
            }
            */
        }
    }


    void OnCollisionEnter2D(Collision2D col)
    {

        if (!hasHit)
        {
            if (col.gameObject.tag == "BulletRocket")
            {
                hasHit = true;
            }
        }
    }

}
