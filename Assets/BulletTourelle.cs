using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTourelle : MonoBehaviour
{
    void Start()
    { }

    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Destroy(this.gameObject);
    }
}
