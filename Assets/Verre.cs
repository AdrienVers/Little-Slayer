﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Verre : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            InventaireControler.Verre += 1;
            Destroy(gameObject);
        }
    }
}
