using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomerangThrow : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 initialPosition;
    bool platformMovingBack;
    public bool canRotate = true;
    public float RotSpeed;

    void Awake()
    {
        RotSpeed = 800f;
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        initialPosition = transform.position;
        canRotate = true;
    }

    void Update()
    {
        if (canRotate)
        {
            transform.Rotate(0, 0, -RotSpeed * Time.deltaTime);
        }

        if (platformMovingBack)
        {
            transform.position = Vector2.MoveTowards(transform.position, initialPosition, 20f * Time.deltaTime);
        }


        if (transform.position.y == initialPosition.y)
        {
            platformMovingBack = false;
        }


        if (GetComponentInChildren<BoomerangTimer>().currentTime == 0)
        {
            Invoke("DropPlatform", 0.5f);
        }
    }


    void DropPlatform()
    {
        rb.isKinematic = false;
        Invoke("GetPlatformBack", 0.5f);
    }

    void GetPlatformBack()
    {
        rb.velocity = Vector2.zero;
        rb.isKinematic = true;
        platformMovingBack = true;

        if (transform.position.y == initialPosition.y)
        {
            Destroy(gameObject);
        }
    }
}