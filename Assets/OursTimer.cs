using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OursTimer : MonoBehaviour
{
    public float currentTime = 0f;
    float startingTime = 6f;

    public GameObject GrenadeText;
    public GameObject FondGris;

    public Text countdownText;

    void Start()
    {
        currentTime = startingTime;
        GrenadeText.gameObject.SetActive(false);
        FondGris.gameObject.SetActive(false);
    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        if (currentTime <= 0)
        {
            currentTime = 0;
        }

        if (currentTime > 4)
        {
            GrenadeText.gameObject.SetActive(false);
            FondGris.gameObject.SetActive(false);
        }

        else if (currentTime <= 4)
        {
            GrenadeText.gameObject.SetActive(true);
            FondGris.gameObject.SetActive(true);
        }

        if (currentTime == 0)
        {
            GetComponentInParent<NounoursThrow>().transform.localScale = new Vector3(6, 6, 0);
            GetComponentInParent<DistanceJoint2D>().enabled = false;
            Destroy(gameObject);
        }
    }
}

