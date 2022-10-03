using UnityEngine;

public class TimerFlamme : MonoBehaviour
{
    public float currentTime = 0f;
    float startingTime = 10f;

    public GameObject Chrono;
    public GameObject FlammeThrow;

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
            startingTime = 10f;
            FlammeThrow.SetActive(false);
        }
    }
}
