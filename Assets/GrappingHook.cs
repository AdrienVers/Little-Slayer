using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrappingHook : MonoBehaviour
{
    DistanceJoint2D joint;
    Vector3 targetPos;
    RaycastHit2D hit;
    public LayerMask mask;
    public float distance = 10f;
    public GameObject Corde;
    private LineRenderer line;

    void Start()
    {
        joint = GetComponent<DistanceJoint2D>();
        joint.enabled = false;

        line = Corde.GetComponent<LineRenderer>();
        //line.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            joint.enabled = true;
            targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            targetPos.z = 0;

            hit = Physics2D.Raycast(transform.position, targetPos - transform.position, distance, mask);

            line.enabled = true;
            //line.SetPosition(0, transform.position);
            //line.SetPosition(1, hit.point);
            line.SetPositions(new Vector3[] { transform.position, hit.point });

            //line.SetPosition(0, transform.position);

            if (hit.collider != null && hit.collider.gameObject.GetComponent<Rigidbody2D>() != null)
            {
                joint.connectedBody = hit.collider.gameObject.GetComponent<Rigidbody2D>();
                joint.connectedAnchor = hit.point - new Vector2(hit.collider.transform.position.x, hit.collider.transform.position.y);
                joint.distance = Vector2.Distance(transform.position, hit.point);
            }
        }

        /*
        if (Input.GetKey(KeyCode.E))
        {
            line.SetPosition(0, transform.position);
        }
        */

        /*
        if (Input.GetKeyUp(KeyCode.E))
        {
            joint.enabled = false;
        }
        */
    }
}
