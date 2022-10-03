using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGrabbable : MonoBehaviour
{
    //public Rigidbody2D rb;
    bool hasHit = false;
    public float Dir = 1;

    public Transform target;

    /*
    void Start()
    {
        target.parent = null;
    }
    */

    void Update()
    {
        if (hasHit == false)
        {
            trackMovement();
        }

        if (GetComponentInChildren<ArrowTimer>().currentTime == 0)
        {
            Destroy(gameObject);
        }
    }

    void trackMovement()
    {
        Vector2 direction = GetComponent<Rigidbody2D>().velocity;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (!hasHit)
        {
            if (col.gameObject.tag == "Box" || col.gameObject.tag == "Player" || col.gameObject.tag == "Mechant")
            {
                transform.parent = col.collider.transform;
            }

            hasHit = true;
            GameObject.Find("Inactif").GetComponentInChildren<HPBar>().HP = GameObject.Find("Inactif").GetComponentInChildren<HPBar>().HP - 5;


            GetComponent<Rigidbody2D>().mass = 0;

            if (GetComponent<Rigidbody2D>().mass < 0.5 && col.gameObject.tag == "Player")
            {
                if (GameObject.Find("Actif").GetComponentInChildren<PlayerMovement>().transform.localScale.x == 1)
                {
                    transform.localScale = new Vector3(-2, 2, 2);
                    transform.eulerAngles = new Vector3(0, 0, transform.rotation.z);
                }

                else if (GameObject.Find("Actif").GetComponentInChildren<PlayerMovement>().transform.localScale.x == -1)
                {
                    transform.localScale = new Vector3(-2, 2, 2);
                    transform.eulerAngles = new Vector3(0, 0, - transform.rotation.z);
                }
            }


            else if (col.gameObject.tag != "Player")
            {
                Destroy(GetComponent<Rigidbody2D>());
                Destroy(GetComponent<PolygonCollider2D>());
            }

            //GetComponent<Rigidbody2D>().velocity = Vector2.zero; // Blocage
            //rb.isKinematic = true;      // Blocage
        }
    }
}
