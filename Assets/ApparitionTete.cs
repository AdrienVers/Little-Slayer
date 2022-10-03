using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApparitionTete : MonoBehaviour
{
    public Transform ShootPoint;
    public GameObject bullet;
    public bool tete = false;

    void Start()
    {
        tete = true;
    }

    void Update()
    {
        if (tete == true)
        {
            Shoot(bullet);
            GameObject.Find("Inactif").GetComponentInChildren<HPBar>().HP = GameObject.Find("Inactif").GetComponentInChildren<HPBar>().HP - 50;
            tete = false;
        }
    }

    public void Shoot(GameObject bullet)
    {
        if (GetComponentInParent<PlayerMovement>().transform.localScale.x == 1)
        {
            GameObject newBullet1 = Instantiate(bullet, ShootPoint.position, transform.rotation);
        }

        if (GetComponentInParent<PlayerMovement>().transform.localScale.x == -1)
        {
            GameObject newBullet1 = Instantiate(bullet, ShootPoint.position, transform.rotation);
        }
    }
}
