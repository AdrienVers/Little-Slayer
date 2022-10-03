using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homing : MonoBehaviour
{
    public float speed = 5;
    public float rotatingSpeed = 200;
    public GameObject target;
    bool hasHit = false;

    Rigidbody2D rb;
    public float fieldoImpact;
    public float force;
    public GameObject ExplosionEffect;
    public LayerMask LayerToHit;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player");
    }

    void FixedUpdate()
    {
        Vector2 point2Target = (Vector2)transform.position - (Vector2)target.transform.position;
        point2Target.Normalize();
        float value = Vector3.Cross(point2Target, transform.right).z;

        /*
        if (value > 0)
        {
            rb.angularVelocity = rotatingSpeed;
        }

        else if (value < 0)
        {
            rb.angularVelocity = -rotatingSpeed;
        }

        else
        {
            rotatingSpeed = 0;
        }
        */

        rb.angularVelocity = rotatingSpeed * value; // Instead of the previous code
        rb.velocity = transform.right * speed;

        if (hasHit)
        {
            explode();
        }
    }

    void explode()
    {
        Collider2D[] objects = Physics2D.OverlapCircleAll(transform.position, fieldoImpact, LayerToHit);
        foreach (Collider2D obj in objects)
        {
            Vector2 direction = obj.transform.position - transform.position;
            obj.GetComponent<Rigidbody2D>().AddForce(direction * force);
        }

        //GameObject.Find("Rouge").GetComponent<PlayerMovement>().enabled = false;
        //GameObject.Find("Mechant").GetComponent<MechantMovement>().enabled = false;

        GameObject ExplosionEffectIns = Instantiate(ExplosionEffect, transform.position, Quaternion.identity);

        Destroy(ExplosionEffectIns, 10);
        Destroy(gameObject);
    }

    void OnDrawGizmosSelected() // Zone d'impacte
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, fieldoImpact);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (!hasHit)
        {
            if (col.gameObject.tag == "Box")
            {
                transform.parent = col.collider.transform;
            }

            if (col.gameObject.tag == "Mechant" || col.gameObject.tag == "Ground")
            {
                GameObject ExplosionEffectIns = Instantiate(ExplosionEffect, transform.position, Quaternion.identity);

                Destroy(ExplosionEffectIns, 10);
                Destroy(gameObject);
            }

            hasHit = true;
        }
    }

}
