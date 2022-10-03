using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TourelleMono : MonoBehaviour
{
    public Transform player;
    public float agroRange;
    //public float moveSpeed;
    Rigidbody2D rb;
    public GameObject Bazooka;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float distToPlayer = Vector2.Distance(transform.position, player.position);

        if (distToPlayer < agroRange)
        {
            ChasePlayer();
        }

        else
        {
            StopChasingPlayer();
        }

    }

    void ChasePlayer()
    {
        /*
        if (transform.position.x < player.position.x)
        {
            //rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
            transform.localScale = new Vector3(1, 1, 1);
            Bazooka.transform.localScale = new Vector3(1, 1, 1);

        }

        else
        {
            //rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
            transform.localScale = new Vector3(-1, 1, 1);
            Bazooka.transform.localScale = new Vector3(-1, 1, 1);
        }
        */
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, agroRange);
    }

    void StopChasingPlayer()
    {
        rb.velocity = new Vector2(0, 0);
    }
}