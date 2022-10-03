using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotTimer : MonoBehaviour
{
    public float currentTime = 0f;
    float startingTime = 4f;

    void Start()
    {
        currentTime = startingTime;
    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;

        if (currentTime <= 0)
        {
            currentTime = 0;
        }
    }
}
