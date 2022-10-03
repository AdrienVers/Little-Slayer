using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aluminium : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            InventaireControler.Fer += 1;
            Destroy(gameObject);
        }
    }
}
