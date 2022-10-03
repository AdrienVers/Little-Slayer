using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigeonMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    public float Dir = 1;
    public float speedForce = 4;
    public float PigeonForce = 8f; // 9.89
    public bool isFlying = false;

    public float startingTime = 10f;
    public float currentTime = 0f;

    public bool up = false;
    public bool down = false;

    public GameObject bullet;
    public Transform ShootPoint;
    public bool fiente = false;

    public float spawnTime;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        currentTime = startingTime;
    }

    public void Update()
    {
        currentTime -= 1 * Time.deltaTime;

        spawnTime = Random.Range(0, 100);

        if (currentTime <= 0)
        {
            currentTime = 0;
        }

        if (currentTime > 5)
        {
            PigeonForce = 9.8f;
            up = false;
            down = true;
        }

        if (currentTime <= 5)
        {
            PigeonForce = 10.5f;
            up = true;
            down = false;
        }

        if (spawnTime == 4)
        {
            fiente = true;
            Shoot(bullet);
        }


        isFlying = true;

        rb.velocity = new Vector2(speedForce, rb.velocity.y);

        //PlayerRight();
        //PlayerLeft();

        //rb.velocity = new Vector2(0, rb.velocity.y);

    }

    void FixedUpdate()
    {
        if (isFlying)
        {
            rb.AddForce(Vector2.up * PigeonForce);
        }
    }


    public void Shoot(GameObject bullet)
    {
            GameObject newBullet1 = Instantiate(bullet, ShootPoint.position, transform.rotation);
    }

    void PlayerRight()
    {
        Dir = 1;
        rb.velocity = new Vector2(speedForce, rb.velocity.y);
        transform.localScale = new Vector3(1.8f, 1.8f, 0);
    }

    void PlayerLeft()
    {
        Dir = -1;
        rb.velocity = new Vector2(-speedForce, rb.velocity.y);
        transform.localScale = new Vector3(-1.8f, 1.8f, 0);
    }

    void Reset()
    {
        currentTime = 1f;
    }
}