using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NuclearBullet : MonoBehaviour
{
    Rigidbody2D rb;

    // Bullet
    public float speed;
    bool hasHit = false;

    public float fieldoImpact;
    public float force;
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

        Destroy(gameObject);
    }

    void OnDrawGizmosSelected() // Zone d'impacte
    {
        //Gizmos.color = Color.red;
        //Gizmos.DrawWireSphere(transform.position, fieldoImpact);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag != "NuclearBomb")
        {
            Destroy(this.gameObject, 0.02f);
        }
    }
}