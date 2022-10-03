using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceToMechant : MonoBehaviour
{
    //public Text distanceText;
    //public float distance;
    public GameObject DetectionMechant;
    public GameObject DetectionPlayer;

    private void Update()
    {
        /*
        distance = (GameObject.Find("Zouka").transform.position.x - transform.position.x);
        distanceText.text = distance.ToString("F1");
        */

        int distancex = Mathf.Abs(Mathf.RoundToInt(GameObject.Find("Zouka").transform.position.x - transform.position.x));
        int distancey = Mathf.Abs(Mathf.RoundToInt(GameObject.Find("Zouka").transform.position.y - transform.position.y));
        //distanceText.text = distancex.ToString("F1");

        if (distancex <= 4 && distancex >= 0 && distancey <= 4 && distancey >= 0)
        {
            DetectionMechant.GetComponent<SpriteRenderer>().color = Color.red;
        }

        else
        {
            DetectionMechant.GetComponent<SpriteRenderer>().color = Color.green;
        }

        int Distancex = Mathf.Abs(Mathf.RoundToInt(GameObject.Find("Rouge").transform.position.x - transform.position.x));
        int Distancey = Mathf.Abs(Mathf.RoundToInt(GameObject.Find("Rouge").transform.position.y - transform.position.y));

        if (Distancex <= 4 && Distancex >= 0 && Distancey <= 4 && Distancey >= 0)
        {
            DetectionPlayer.GetComponent<SpriteRenderer>().color = Color.red;
        }

        else
        {
            DetectionPlayer.GetComponent<SpriteRenderer>().color = Color.green;
        }

    }
}
