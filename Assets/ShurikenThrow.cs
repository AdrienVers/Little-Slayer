using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShurikenThrow : MonoBehaviour
{
    public Rigidbody2D rb;
    public Transform target;

    // Shuriken-Throw
    public bool canRotate = true;
    public float RotSpeed;
    bool hasHit = false;

    void Awake()
    {
        RotSpeed = Random.Range(200f, 800f);
    }

    void Start()
    {
        canRotate = true;
    }

    void Update()
    {
        //if (hasHit == false){ trackMovement();}

        if (canRotate)
        {
            transform.Rotate(0, 0, -RotSpeed * Time.deltaTime);
        }
    }

    void trackMovement()
    {
        Vector2 direction = rb.velocity;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        /*
        if (hasHit == true)
        {
            rb.velocity = Vector2.zero;
            rb.isKinematic = true;
            rb.freezeRotation = true;
            canRotate = false;
        */

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

            rb.velocity = Vector2.zero;
            rb.isKinematic = true;
            rb.freezeRotation = true;
            canRotate = false;
            Destroy(rb);
            Destroy(GetComponentInChildren<PolygonCollider2D>());

            //rb.velocity = Vector2.zero; // Blocage
            //rb.isKinematic = true;      // Blocage
        }
    }
}
