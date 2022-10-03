using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoomerangTimer : MonoBehaviour
{
    public float currentTime = 0f;
    float startingTime = 1f;

    //public GameObject BoomerangText;
    //public Text countdownText;

    void Start()
    {
        currentTime = startingTime;
        //BoomerangText.gameObject.SetActive(false);
    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        //countdownText.text = currentTime.ToString("0");

        if (currentTime <= 0)
        {
            currentTime = 0;
        }
    }
}
