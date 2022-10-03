using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeBlade : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool BladeHasHit = false;

    void Start()
    { }

    void Update()
    { }

    void OnCollisionEnter2D(Collision2D col)
    {
        BladeHasHit = true;
    }
}