using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cuivre : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            InventaireControler.Cuivre += 1;
            Destroy(gameObject);
        }
    }
}
