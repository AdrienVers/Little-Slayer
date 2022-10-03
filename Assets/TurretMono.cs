using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretMono : MonoBehaviour
{
    public float distance;
    public float wakeRange = 15;
    public float fireRange = 10;

    public float shootInterval;
    public float bulletSpeed = 100;
    public float bulletTimer;

    public bool awake = false;
    public bool fire = false;

    public bool lookingRight = false;

    public GameObject Light;
    public GameObject Eyes;

    public GameObject bullet;

    public Transform target;
    public string Player = "Player";

    Vector2 Direction;

    public GameObject Gun;
    public Transform shootPointLeft;

    void Awake()
    {
        //anim = gameObject.GetComponent<Animator>();
        Eyes.SetActive(false);
    }

    void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
    }

    void UpdateTarget()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(Player);
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;

        foreach (GameObject Player in enemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, Player.transform.position);
            if (distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = Player;
            }
        }

        if (nearestEnemy != null && shortestDistance <= wakeRange)
        {
            target = nearestEnemy.transform;
        }

        else
        {
            target = null;
        }
    }


    void Update()
    {
        if (target == null)
        { return; }

        Vector2 targetPos = target.position;
        Direction = targetPos - (Vector2)transform.position;

        if (awake == true)
        {
            Light.GetComponent<SpriteRenderer>().color = Color.red;
            Gun.transform.right = Direction;
        }

        else if (awake == false)
        {
            Light.GetComponent<SpriteRenderer>().color = Color.white;
        }

        RangeCheck();
        FireCheck();

        if (target.transform.position.x > transform.position.x)
        {
            lookingRight = true;
        }

        if (target.transform.position.x < transform.position.x)
        {
            lookingRight = false;
        }

        if (fire == true)
        {
            Eyes.SetActive(true);

        }

        else if (fire == false)
        {
            Eyes.SetActive(false);
        }

    }


    void RangeCheck()
    {
        distance = Vector3.Distance(transform.position, target.transform.position);

        if (distance < wakeRange)
        {
            awake = true;
        }

        if (distance > wakeRange)
        {
            awake = false;
        }
    }


    void FireCheck()
    {
        distance = Vector3.Distance(transform.position, target.transform.position);

        if (distance < fireRange)
        {
            fire = true;
        }

        if (distance > fireRange)
        {
            fire = false;
        }
    }

    public void Attack(bool awake)
    {
        bulletTimer += Time.deltaTime;

        if (bulletTimer >= shootInterval)
        {
            Vector2 direction = target.transform.position - transform.position;
            direction.Normalize();

            if (!awake)
            {
                GameObject bulletClone;
                bulletClone = Instantiate(bullet, shootPointLeft.transform.position, shootPointLeft.transform.rotation) as GameObject;
                bulletClone.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;

                bulletTimer = 0;
            }

            /*
            if (attackingRight)
            {
                GameObject bulletClone;
                bulletClone = Instantiate(bullet, shootPointRight.transform.position, shootPointRight.transform.rotation) as GameObject;
                bulletClone.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;

                bulletTimer = 0;
            }
            */
        }
    }
}
