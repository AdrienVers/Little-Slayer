using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeHandle : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool HandleHasHit = false;

    void Start()
    { }

    void Update()
    { }

    void OnCollisionEnter2D(Collision2D col)
    {
        HandleHasHit = true;
    }
}
