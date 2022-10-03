using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CasqueManager : MonoBehaviour
{
    bool hasSniper = false;
    bool hasPompe = false;
    bool hasRocket = false;
    bool hasHitRouge = false;
    bool hasHitBleu = false;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
            /*
            else if (hasHitBleu)
            {
                GameObject.Find("Bleu").GetComponent<HPBar>().HP = GameObject.Find("Bleu").GetComponent<HPBar>().HP - 20;
                hasHitBleu = false;
            }
            */
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        /*
        if (col.gameObject.name == "BulletSniper")
        {
            GameObject.Find("Bleu").GetComponent<HPBar>().HP = GameObject.Find("Bleu").GetComponent<HPBar>().HP + 20;
        }
        */

        /*
        if (col.gameObject.name == "Rouge")
        {
            hasHit = true;
            hasHitRouge = true;
        }

        else if (col.gameObject.name == "Bleu")
        {
            hasHit = true;
            hasHitBleu = true;
        }
        */
    }
}

