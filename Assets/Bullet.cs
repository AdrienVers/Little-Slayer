using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    bool hasHit = false;

    public float fieldoImpact;
    public float force;
    public GameObject ExplosionEffect;
    public LayerMask LayerToHit;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
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

            if (col.gameObject.tag == "Mechant")
            {
                GameObject ExplosionEffectIns = Instantiate(ExplosionEffect, transform.position, Quaternion.identity);

                Destroy(ExplosionEffectIns, 10);
                Destroy(gameObject);
            }

            hasHit = true;
        }
    }
}