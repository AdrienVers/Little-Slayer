using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomingMaster : MonoBehaviour
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
        target = GameObject.FindGameObjectWithTag("Target");
    }

    void FixedUpdate()
    {
        Vector2 point2Target = (Vector2)transform.position - (Vector2)target.transform.position;
        point2Target.Normalize();
        float value = Vector3.Cross(point2Target, transform.right).z;

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

        GameObject ExplosionEffectIns = Instantiate(ExplosionEffect, transform.position, Quaternion.identity);

        Destroy(ExplosionEffectIns, 10);
        Destroy(target);
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
            hasHit = true;

            /*
            GameObject ExplosionEffectIns = Instantiate(ExplosionEffect, transform.position, Quaternion.identity);

            Destroy(ExplosionEffectIns, 10);
            Destroy(target);
            Destroy(gameObject);
            */
        }
    }

}