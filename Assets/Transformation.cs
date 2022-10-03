using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transformation : MonoBehaviour
{
    public GameObject Vivant;
    public GameObject Bois;
    public GameObject Charbon;
    //public GameObject Chrono;

    public bool hasHit = false;


    void Awake()
    {
        Vivant.SetActive(true);
        //Chrono.SetActive(false);
        Bois.SetActive(false);
        Charbon.SetActive(false);
    }

    void Update()
    {
        if (hasHit == true)
        {

            Vivant.SetActive(false);
            Bois.SetActive(true);
            Charbon.SetActive(true);

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
