using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 2 * 59;

    public Text countdownText;

    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        //countdownText.text = currentTime.ToString("0");
        countdownText.text = string.Format("{0:0}:{1:00}", Mathf.Floor(currentTime / 59), currentTime % 59);

        if (currentTime <= 0)
        {
            currentTime = 0;
        }
    }
}
