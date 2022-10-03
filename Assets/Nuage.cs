using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nuage : MonoBehaviour
{
    bool hasHit = false;
    public GameObject ExplosionEffect;

    float speedForce = 0.2f;

    void Start()
    { }


    void Update()
    {
        //GetComponent<Rigidbody2D>().velocity = new Vector2(-speedForce, GetComponent<Rigidbody2D>().velocity.y);
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        if (!hasHit)
        {
            if (col.gameObject.tag == "Money")
            {
                hasHit = false;
            }

            else 
            {
                hasHit = true;

                GameObject ExplosionEffectIns = Instantiate(ExplosionEffect, transform.position, Quaternion.identity);
                Destroy(ExplosionEffectIns, 10);
                Destroy(gameObject);
            }

            
        }
    }
}
