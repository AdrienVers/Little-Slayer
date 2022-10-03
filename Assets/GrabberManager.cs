using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabberManager : MonoBehaviour
{
    public bool grabbed;
    RaycastHit2D hit;
    public float distance = 1;
    public Transform HoldPoint2;
    public float ThrowForce;
    public LayerMask notgrabbed;

    void Start()
    {
        
    }

    void Update()
    {
        if (!grabbed)
        {
            Physics2D.queriesStartInColliders = false;
            //hit = Physics2D.Raycast(transform.position, Vector2.right * transform.localScale.x);
            //hit = Physics2D.Raycast(transform.position, Vector2.right * transform.localScale.x);
            hit = Physics2D.CircleCast(transform.position, distance, Vector2.right * transform.localScale.x);

            if (hit.collider != null && hit.collider.tag == "Arrow")
            {
                grabbed = true;
            }
        }

        /*
        else if (!Physics2D.OverlapPoint(HoldPoint.position,notgrabbed))
        // throw
        {
            grabbed = false;

            if(hit.collider.gameObject.GetComponent<Rigidbody2D>() != null)
            {
                hit.collider.GetComponent<Rigidbody2D>().velocity = new Vector2(transform.localScale.x, 1)*ThrowForce;
            }
        }
        */

        if (grabbed)
        {
                hit.collider.gameObject.transform.position = HoldPoint2.position;
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.right * transform.localScale.x * distance);
        //Gizmos.DrawLine(transform.position, transform.position + Vector3.up * distance);
        //Gizmos.DrawSphere(transform.position, distance);
    }
}
