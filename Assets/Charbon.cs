using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charbon : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            InventaireControler.Charbon += 1;
            Destroy(gameObject);
        }
    }
}
