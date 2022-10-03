using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TroncThrow : MonoBehaviour
{
    bool hasHit = false;
    bool hasHitRouge = false;
    bool hasHitBleu = false;

    void Update()
    {
        if (hasHit)
        {
            if (hasHitRouge)
            {
                GameObject.Find("Rouge").GetComponent<HPBar>().HP = GameObject.Find("Rouge").GetComponent<HPBar>().HP - 20;
                hasHitRouge = false;
            }

            else if (hasHitBleu)
            {
                GameObject.Find("Bleu").GetComponent<HPBar>().HP = GameObject.Find("Bleu").GetComponent<HPBar>().HP - 20;
                hasHitBleu = false;
            }
        }
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        if (!hasHit)
        {
            if (col.gameObject.tag == "Box" || col.gameObject.tag == "Mechant")
            {
                hasHit = true;
                //transform.parent = col.collider.transform;
            }

            if (col.gameObject.name == "Rouge")
            {
                hasHit = true;
                hasHitRouge = true;
            }

            if (col.gameObject.name == "Bleu")
            {
                hasHit = true;
                hasHitBleu = true;
            }
        }
    }
}