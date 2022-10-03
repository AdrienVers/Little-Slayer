using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPDetection : MonoBehaviour
{
    public bool Detected = false;
    public float agroRange;
    public GameObject AlarmLight;

    void Start()
    {}

    void Update()
    {

        float distToPlayer = Vector2.Distance(transform.position, GameObject.Find("Bleu").transform.position);

        if (distToPlayer < agroRange)
        {
            ChasePlayer();
        }

        else
        {
            StopChasingPlayer();
        }
    }

    void ChasePlayer()
    {
        if (transform.position.x < GameObject.Find("Bleu").transform.position.x)
        {
            Detected = true;
            AlarmLight.GetComponent<SpriteRenderer>().color = Color.green;
        }

        else if (transform.position.x > GameObject.Find("Bleu").transform.position.x)
        {
            Detected = true;
            AlarmLight.GetComponent<SpriteRenderer>().color = Color.green;
        }
        

    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, agroRange);
    }
    

    void StopChasingPlayer()
    { }

   
}