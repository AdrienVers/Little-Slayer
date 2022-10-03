using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrappinLine : MonoBehaviour
{
    public float agroRange;
    public Transform castPoint;
    private LineRenderer lr;
    bool isFacingLeft;

    void Start()
    {
        lr = GetComponent<LineRenderer>();
    }

    void Update()
    {
        if (CanSeePlayer(agroRange))
        {

        }

        else
        {

        }


        //Vector3 endPosition = transform.position + (transform.right * agroRange);
        //lr.SetPositions(new Vector3[] { transform.position, endPosition });
    }


    bool CanSeePlayer(float distance)
    {
        bool val = false;
        float castDist = distance;

        if (isFacingLeft == true)
        {
            castDist = -distance;
        }


        Vector3 endPos = castPoint.position + transform.right * castDist;

        RaycastHit2D hit = Physics2D.Linecast(castPoint.position, endPos, 1 << LayerMask.NameToLayer("Action") | 1 << LayerMask.NameToLayer("Mechant") | 1 << LayerMask.NameToLayer("Ground") | 1 << LayerMask.NameToLayer("Default"));

        if (hit.collider != null)
        {
            if (hit.collider.gameObject.CompareTag("Player"))
            {
                val = true;
            }

            else
            {
                val = false;
            }

            //Debug.DrawLine(castPoint.position, hit.point, Color.red);
            lr.SetPositions(new Vector3[] { transform.position, hit.point });
        }

        else
        {
            //Debug.DrawLine(castPoint.position, endPos, Color.blue);
            lr.SetPositions(new Vector3[] { transform.position, endPos });
        }

        return val;
    }
}