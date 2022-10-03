using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerUzi : MonoBehaviour
{
    public float currentTime = 0f;
    float startingTime = 3f;

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
