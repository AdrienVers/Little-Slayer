using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tourelle : MonoBehaviour
{
    public float Range = 10;
    public Transform Target;
    public bool Detected = false;
    Vector2 Direction;

    public GameObject AlarmLight;
    public GameObject Gun;
    public GameObject Bullet;

    public float FireRate;
    //float nextTimeToFire = 0;

    public Transform ShootPoint;

    public float Force = 120;

    float fireRate = 0.2f;
    float lastShot = 0.0f;

    void Start()
    { }

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
                    AlarmLight.GetComponent<SpriteRenderer>().color = Color.red;
                }
            }

            else
            {
                if (Detected == true)
                {
                    Detected = false;
                    AlarmLight.GetComponent<SpriteRenderer>().color = Color.green;
                }
            }
        }

        if (Detected)
        {
            Gun.transform.right = Direction;
            if (Time.time > fireRate + lastShot)
            {
                shoot();
                lastShot = Time.time;
            }
        }
    }

    void shoot()
    {
        GameObject BulletIns = Instantiate(Bullet, ShootPoint.position, Quaternion.identity);
        BulletIns.GetComponent<Rigidbody2D>().AddForce(Direction * Force);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, Range);
    }
}
