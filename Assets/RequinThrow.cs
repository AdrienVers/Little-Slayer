using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RequinThrow : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    bool hasHit = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //rb.velocity = transform.right * speed;
        rb.velocity = transform.up * speed;
    }

    void Update()
    {
        if (hasHit)
        {
            explode();
        }
    }

    void explode()
    {
        //Destroy(gameObject);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (!hasHit)
        {
            if (col.gameObject.tag == "Box")
            {
                transform.parent = col.collider.transform;
            }

            if (col.gameObject.tag == "Mechant")
            {
                //Destroy(gameObject);
            }

            hasHit = true;
            rb = GetComponent<Rigidbody2D>();
            rb.velocity = transform.up * 30;
        }
    }
}