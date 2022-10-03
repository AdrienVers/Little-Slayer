using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zouka : MonoBehaviour
{
    public float Range;
    public Transform Target;
    public bool Detected = false;
    public Vector2 Direction;

    //public GameObject AlarmLight;
    public GameObject Bazooka;
    public GameObject Bullet;

    public float FireRate;
    float nextTimeToFire = 0;

    public Transform ShootRightPoint;
    public Transform ShootLeftPoint;
    public float Force;

    public float counter = 0;

    void Awake()
    {
        if (GetComponentInParent<MechantMovement>().transform.localScale.x == -1 && transform.localScale.x == 1)
        {
            Bazooka.transform.eulerAngles = new Vector3(0, 0, 180);
            Bazooka.transform.localScale = new Vector3(-1, -1, 0);
        }

        if (GetComponentInParent<MechantMovement>().transform.localScale.x == -1 && transform.localScale.x == -1)
        {
            Bazooka.transform.eulerAngles = new Vector3(0, 0, 180);
            Bazooka.transform.localScale = new Vector3(1, -1, 0);
        }

        if (GetComponentInParent<MechantMovement>().transform.localScale.x == 1 && transform.localScale.x == 1)
        {
            Bazooka.transform.eulerAngles = new Vector3(0, 0, 0);
            Bazooka.transform.localScale = new Vector3(1, 1, 0);
        }

        if (GetComponentInParent<MechantMovement>().transform.localScale.x == 1 && transform.localScale.x == -1)
        {
            Bazooka.transform.eulerAngles = new Vector3(0, 0, 0);
            Bazooka.transform.localScale = new Vector3(-1, 1, 0);
        }
    }

    void Start()
    { }

    void FixedUpdate()
    {  }

    void Update()
    {
        Vector2 targetPos = Target.position;
        Direction = targetPos - (Vector2)transform.position;
        RaycastHit2D rayInfo = Physics2D.Raycast(transform.position, Direction, Range);

        if (rayInfo)
        {
            if (rayInfo.collider.gameObject.tag == "Player")
            {
                if (Detected == false)
                {
                    Detected = true;
                    //AlarmLight.GetComponent<SpriteRenderer>().color = Color.red;
                }
            }

            else
            {
                if (Detected == true)
                {
                    Detected = false;
                    //AlarmLight.GetComponent<SpriteRenderer>().color = Color.green;
                }
            }
        }

        if (Detected)
        {
            if (GetComponentInParent<MechantMovement>().transform.localScale.x == -1)
            {
                /*
                Bazooka.transform.localScale = new Vector3(-1, -1, 0);
                Bazooka.transform.eulerAngles = new Vector3(0, 0, 180);

                if (Bazooka.transform.eulerAngles.z <= 89) { Bazooka.transform.eulerAngles = new Vector3(0, 0, 90); } // HAUT
                if (Bazooka.transform.eulerAngles.z >= 270 && Bazooka.transform.eulerAngles.z <= 360) { transform.eulerAngles = new Vector3(0, 0, -90); } // BAS
                */

                if (Direction.x >= -3)
                {
                    Direction.x = -3;
                }

                if (Direction.y == 0.5)
                {
                    Direction.y = 0.5f;
                }

                if (Direction.y == -0.5)
                {
                    Direction.y = -0.5f;
                }

            }

            if (GetComponentInParent<MechantMovement>().transform.localScale.x == 1)
            {
                /*
                Bazooka.transform.localScale = new Vector3(1, 1, 0);
                Bazooka.transform.eulerAngles = new Vector3(0, 0, 0);

                if (Bazooka.transform.eulerAngles.z >= 90 && transform.eulerAngles.z <= 180) { transform.eulerAngles = new Vector3(0, 0, 90); } // HAUT
                if (Bazooka.transform.eulerAngles.z <= 270 && transform.eulerAngles.z >= 180) { transform.eulerAngles = new Vector3(0, 0, -90); } // BAS
                */

                if (Direction.x <= 3)
                {
                    Direction.x = 3;
                }

                if (Direction.y == 0.5)
                {
                    Direction.y = 0.5f;
                }

                if (Direction.y == -0.5)
                {
                    Direction.y = -0.5f;
                }

            }

            Bazooka.transform.right = Direction;

            if (Time.time > nextTimeToFire)
            {
                nextTimeToFire = Time.time / FireRate;
                shoot();
            }
        }
    }

    void shoot()
    {
        counter += 1;

        if (counter == 1)
        {
            if (GetComponentInParent<MechantMovement>().transform.localScale.x == 1)
            {
                GameObject BulletIns = Instantiate(Bullet, ShootRightPoint.position, transform.rotation);
                BulletIns.GetComponent<Rigidbody2D>().AddForce(Direction * Force);
            }

            if (GetComponentInParent<MechantMovement>().transform.localScale.x == -1)
            {
                GameObject BulletIns = Instantiate(Bullet, ShootLeftPoint.position, transform.rotation);
                BulletIns.GetComponent<Rigidbody2D>().AddForce(Direction * Force);
            }
        }

        if (counter == 400)
        {
            counter = 0;
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, Range);
    }
}
