using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acier : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            InventaireControler.Acier += 1;
            Destroy(gameObject);
        }
    }
}
