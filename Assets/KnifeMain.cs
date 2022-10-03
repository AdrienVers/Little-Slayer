using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeMain : MonoBehaviour
{
    public Rigidbody2D rb;
    bool hasHit = false;

    public Transform target;

    // Knife-Throw
    public bool canRotate = true;
    public float RotSpeed;

    bool hasHitRouge = false;
    bool hasHitBleu = false;

    bool bladehashit = false;
    bool handlehashit = false;

    public GameObject blade;
    public GameObject handle;

    void Awake()
    {
        RotSpeed = Random.Range(200f, 800f);
        Debug.Log(RotSpeed);
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

        if (hasHit)
        {
            if (hasHitRouge & handlehashit)
            {
                GameObject.Find("Rouge").GetComponent<HPBar>().HP = GameObject.Find("Rouge").GetComponent<HPBar>().HP - 5;
                hasHitRouge = false;
            }

            else if (hasHitBleu && handlehashit)
            {
                GameObject.Find("Bleu").GetComponent<HPBar>().HP = GameObject.Find("Bleu").GetComponent<HPBar>().HP - 5;
                hasHitBleu = false;
            }

            if (hasHitRouge && bladehashit)
            {
                GameObject.Find("Rouge").GetComponent<HPBar>().HP = GameObject.Find("Rouge").GetComponent<HPBar>().HP - 20;
                hasHitRouge = false;
            }

            else if (hasHitBleu && bladehashit)
            {
                GameObject.Find("Bleu").GetComponent<HPBar>().HP = GameObject.Find("Bleu").GetComponent<HPBar>().HP - 20;
                hasHitBleu = false;
            }
        }
    }

    void trackMovement()
    {
        Vector2 direction = rb.velocity;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

    void OnCollisionEnter2D(Collision2D col)
    {

        if (!hasHit)
        {
            if (blade != null)
            {
                if (GetComponentInChildren<KnifeBlade>().BladeHasHit == true)
                {
                    if (col.gameObject.tag == "Box" || col.gameObject.tag == "Player" || col.gameObject.tag == "Mechant")
                    {
                        transform.parent = col.collider.transform;
                        Destroy(handle.GetComponent<PolygonCollider2D>());
                    }

                    if (col.gameObject.name == "Rouge")
                    {
                        hasHitRouge = true;
                    }

                    else if (col.gameObject.name == "Bleu")
                    {
                        hasHitBleu = true;
                    }

                    if (col.gameObject.tag == "Arbre")
                    {
                        transform.parent = GameObject.Find("Arbre").transform;
                    }

                    if (col.gameObject.tag == "Nuage")
                    {
                        Destroy(gameObject);
                    }

                    if (col.gameObject.tag == "Ground")
                    {
                        Destroy(gameObject, 10);
                    }

                    bladehashit = true;
                    hasHit = true;

                    rb.velocity = Vector2.zero;
                    rb.isKinematic = true;
                    rb.freezeRotation = true;
                    canRotate = false;
                    Destroy(rb);
                    Destroy(GetComponentInChildren<PolygonCollider2D>());
                }
            }

            

            if (GetComponentInChildren<KnifeHandle>().HandleHasHit == true)
            {
                handlehashit = true;
                canRotate = false;

                if (col.gameObject.name == "Rouge")
                {
                    hasHit = true;
                    hasHitRouge = true;
                    canRotate = false;
                }

                else if (col.gameObject.name == "Bleu")
                {
                    hasHit = true;
                    hasHitBleu = true;
                    canRotate = false;
                }
            }

            if (handlehashit == true)
            {
                Destroy(blade);
            }
        }
    }
}