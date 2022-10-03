using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bois : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            InventaireControler.Bois += 1;
            Destroy(gameObject);
        }
    }
}
