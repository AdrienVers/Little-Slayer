using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaillouxThrow : MonoBehaviour
{
    public bool canRotate = true;
    public float RotSpeed;

    bool hasHit = false;
    bool hasHitRouge = false;
    bool hasHitBleu = false;

    void Awake()
    {
        RotSpeed = Random.Range(400f, 800f);
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
                canRotate = false;
                //transform.parent = col.collider.transform;
            }

            if (col.gameObject.name == "Rouge")
            {
                hasHit = true;
                hasHitRouge = true;
                canRotate = false;
            }

            if (col.gameObject.name == "Bleu")
            {
                hasHit = true;
                hasHitBleu = true;
                canRotate = false;
            }
        }
    }
}
