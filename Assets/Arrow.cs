using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public Rigidbody2D rb;
    bool hasHit = false;

    //public GameObject DetectionArbre;
    //public bool Arbre30 = false;

    //public Transform target;

    void Start()
    {
        //target.parent = null;
    }

    void Update()
    {
        if (hasHit == false)
        {
            trackMovement();
        }

        /*
        int distancex = Mathf.Abs(Mathf.RoundToInt(GameObject.Find("Arbre").GetComponent<Arbre>().transform.position.x - transform.position.x));
        int distancey = Mathf.Abs(Mathf.RoundToInt(GameObject.Find("Arbre").GetComponent<Arbre>().transform.position.y - transform.position.y));

        if (distancex <= 5 && distancex >= 0 && distancey <= 5 && distancey >= 0)
        {
            DetectionArbre.GetComponent<SpriteRenderer>().color = Color.red;
            Arbre30 = true;
        }
        */
    }

    void trackMovement()
    {
        Vector2 direction = rb.velocity;

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

            if (col.gameObject.tag == "Arbre")
            {
                transform.parent = GameObject.Find("Arbre").transform;
            }

            if (col.gameObject.tag == "Nuage")
            {
                Destroy(gameObject);
            }

            if (col.gameObject.tag == "Ground")
            {
                Destroy(gameObject, 10);
            }


            hasHit = true;

            Destroy(rb);
            Destroy(GetComponent<PolygonCollider2D>());

            //rb.velocity = Vector2.zero; // Blocage
            //rb.isKinematic = true;      // Blocage
        }
    }
}
