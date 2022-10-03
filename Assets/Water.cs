using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    //public float counter = 0;

    //float speedForce = 1;
    public float fireRate = 0.1f;
    public float lastShoot = 0.0f;

    void Start()
    {}


    void Update()
    {
        /*
        if (Time.time > fireRate + lastShot)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-speedForce, GetComponent<Rigidbody2D>().velocity.x);
            lastShot = Time.time;
        }
        */

        /*
        if (Time.time > fireRate + lastShoot)
        {
            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y - 0.05f, transform.localPosition.z);
            lastShoot = Time.time;
        }
        */
        /*
            if (Time.deltaTime > fireRate + lastShoot)
            {
                if (lastShoot > 0 && lastShoot <= 3)
                {
                    transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y - 0.01f, transform.localPosition.z);
                }

                if (lastShoot > 3 && lastShoot <= 6)
                {
                    transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + 0.01f, transform.localPosition.z);
                }

                lastShoot = Time.deltaTime;

                if (lastShoot > 6)
                {
                    lastShoot = 0;
                }

            }
            */

    //transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + 0.5f, transform.localPosition.z);


    /*
    if (counter == 0)
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(-speedForce, GetComponent<Rigidbody2D>().velocity.x);
        counter = counter + 1;
    }

    else if (counter == 1)
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(-speedForce, GetComponent<Rigidbody2D>().velocity.x);
        counter = counter + 1;
    }

    else if (counter == 2)
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(speedForce, GetComponent<Rigidbody2D>().velocity.x);
        counter = counter + 1;
    }

    else if (counter == 3)
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(speedForce, GetComponent<Rigidbody2D>().velocity.x);
        counter = 0;
    }
    */
}
    
}
