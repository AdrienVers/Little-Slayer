using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerExtinceur : MonoBehaviour
{
    public float currentTime = 0f;
    float startingTime = 6f;

    public GameObject SnowThrow;

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

        if (currentTime == 0)
        {
            startingTime = 6f;
            SnowThrow.SetActive(false);
        }
    }
}