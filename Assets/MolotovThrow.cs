using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MolotovThrow : MonoBehaviour
{
    public bool canRotate = true;
    public float RotSpeed;

    bool hasHit = false;
    bool hasHitRouge = false;
    bool hasHitBleu = false;

    public Transform ShootPoint1;
    public Transform ShootPoint2;
    public Transform ShootPoint3;
    public Transform ShootPoint4;
    public Transform ShootPoint5;
    public Transform ShootPoint6;

    public GameObject ExplosionEffect;
    public GameObject Flamme1;
    public GameObject Flamme2;
    public GameObject Flamme3;
    public GameObject Flamme4;
    public GameObject Flamme5;
    public GameObject Flamme6;

    void Awake()
    {
        RotSpeed = Random.Range(200f, 300f);
    }

    void Start()
    {
        canRotate = true;
    }

    void Update()
    {
        if (canRotate)
        {
            transform.Rotate(0, 0, -RotSpeed * Time.deltaTime);
        }

        if (GetComponent<MolotovTimer>().currentTime == 0)
        {
            GameObject ExplosionEffectIns = Instantiate(ExplosionEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

        if (hasHit)
        {
            if (hasHitRouge)
            {
                GameObject.Find("Rouge").GetComponent<HPBar>().HP = GameObject.Find("Rouge").GetComponent<HPBar>().HP - 5;
                hasHitRouge = false;
            }

            else if (hasHitBleu)
            {
                GameObject.Find("Bleu").GetComponent<HPBar>().HP = GameObject.Find("Bleu").GetComponent<HPBar>().HP - 5;
                hasHitBleu = false;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (!hasHit)
        {
            if (col.gameObject.tag == "Box" || col.gameObject.tag == "Mechant" || col.gameObject.tag == "Arbre" || col.gameObject.tag == "Ground")
            {
                hasHit = true;
                GameObject ExplosionEffectIns = Instantiate(ExplosionEffect, transform.position, Quaternion.identity);
                GameObject ExplosionEffectIns1 = Instantiate(Flamme1, ShootPoint1.position, Quaternion.identity);
                GameObject ExplosionEffectIns2 = Instantiate(Flamme2, ShootPoint2.position, Quaternion.identity);
                GameObject ExplosionEffectIns3 = Instantiate(Flamme3, ShootPoint3.position, Quaternion.identity);
                GameObject ExplosionEffectIns4 = Instantiate(Flamme4, ShootPoint4.position, Quaternion.identity);
                GameObject ExplosionEffectIns5 = Instantiate(Flamme5, ShootPoint5.position, Quaternion.identity);
                GameObject ExplosionEffectIns6 = Instantiate(Flamme6, ShootPoint6.position, Quaternion.identity);
                Destroy(ExplosionEffectIns, 2);
                Destroy(ExplosionEffectIns1, 7);
                Destroy(ExplosionEffectIns2, 7);
                Destroy(ExplosionEffectIns3, 7);
                Destroy(ExplosionEffectIns4, 7);
                Destroy(ExplosionEffectIns5, 7);
                Destroy(ExplosionEffectIns6, 7);
                Destroy(gameObject);
                //transform.parent = col.collider.transform;
            }

            if (col.gameObject.name == "Rouge")
            {
                hasHit = true;
                hasHitRouge = true;
                GameObject ExplosionEffectIns = Instantiate(ExplosionEffect, transform.position, Quaternion.identity);
                GameObject ExplosionEffectIns1 = Instantiate(Flamme1, ShootPoint1.position, Quaternion.identity);
                GameObject ExplosionEffectIns2 = Instantiate(Flamme2, ShootPoint2.position, Quaternion.identity);
                GameObject ExplosionEffectIns3 = Instantiate(Flamme3, ShootPoint3.position, Quaternion.identity);
                GameObject ExplosionEffectIns4 = Instantiate(Flamme4, ShootPoint4.position, Quaternion.identity);
                GameObject ExplosionEffectIns5 = Instantiate(Flamme5, ShootPoint5.position, Quaternion.identity);
                GameObject ExplosionEffectIns6 = Instantiate(Flamme6, ShootPoint6.position, Quaternion.identity);

                Destroy(ExplosionEffectIns, 2);
                Destroy(ExplosionEffectIns1, 7);
                Destroy(ExplosionEffectIns2, 7);
                Destroy(ExplosionEffectIns3, 7);
                Destroy(ExplosionEffectIns4, 7);
                Destroy(ExplosionEffectIns5, 7);
                Destroy(ExplosionEffectIns6, 7);
                Destroy(gameObject);
            }

            if (col.gameObject.name == "Bleu")
            {
                hasHit = true;
                hasHitBleu = true;
                GameObject ExplosionEffectIns = Instantiate(ExplosionEffect, transform.position, Quaternion.identity);
                GameObject ExplosionEffectIns1 = Instantiate(Flamme1, ShootPoint1.position, Quaternion.identity);
                GameObject ExplosionEffectIns2 = Instantiate(Flamme2, ShootPoint2.position, Quaternion.identity);
                GameObject ExplosionEffectIns3 = Instantiate(Flamme3, ShootPoint3.position, Quaternion.identity);
                GameObject ExplosionEffectIns4 = Instantiate(Flamme4, ShootPoint4.position, Quaternion.identity);
                GameObject ExplosionEffectIns5 = Instantiate(Flamme5, ShootPoint5.position, Quaternion.identity);
                GameObject ExplosionEffectIns6 = Instantiate(Flamme6, ShootPoint6.position, Quaternion.identity);
                Destroy(ExplosionEffectIns, 2);
                Destroy(ExplosionEffectIns1, 7);
                Destroy(ExplosionEffectIns2, 7);
                Destroy(ExplosionEffectIns3, 7);
                Destroy(ExplosionEffectIns4, 7);
                Destroy(ExplosionEffectIns5, 7);
                Destroy(ExplosionEffectIns6, 7);
                Destroy(gameObject);
            }
        }
    }
}