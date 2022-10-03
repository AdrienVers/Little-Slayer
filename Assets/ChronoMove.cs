using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChronoMove : MonoBehaviour
{
    public float startingTime = 4f;
    public float currentTime = 0f;

    /*
    void Awake()
    {
        GameObject.Find("Actif").GetComponent<ChronoMove>().enabled = false;
        GameObject.Find("Inactif").GetComponent<ChronoMove>().enabled = false;
    }
    */

    void Start()
    {
        currentTime = startingTime;
    }

    void Update()
    {
        if (GameObject.Find("Actif").GetComponent<ChronoMove>().enabled == true || GameObject.Find("Inactif").GetComponent<ChronoMove>().enabled == true)
        {
            currentTime -= 1 * Time.deltaTime;

            if (currentTime <= 0)
            {
                currentTime = 0;
            }
        }

        //Resources.FindObjectsOfTypeAll(<GrenadeThrow>)
        //Resources.Load("Prefabs/Grenade") as GameObject
        //_Grenade = Resources.Load("Assets/Prefabs/Grenade") as GameObject;

        /*
        if (currentTime == 0)
        {
            GameObject.Find("Actif").GetComponent<Move>().enabled = true;
            GameObject.Find("Inactif").GetComponent<Move>().enabled = true;
        }
        */

        //if (GameObject.Find("Actif").GetComponent<Move>().enabled == true || GameObject.Find("Inactif").GetComponent<Move>().enabled == true)
        //_Grenade.GetComponent<GrenadeThrow>().Player30 == true || _Grenade.GetComponent<GrenadeThrow>().Mechant30 == true) // GameObject.Find("Grenade").GetComponent<GrenadeThrow>().Mechant30 == true


        if (currentTime == 0)
        {
            //GameObject.Find("Actif").GetComponentInChildren<PlayerMovement>().enabled = true;
            //GameObject.Find("Inactif").GetComponentInChildren<PlayerMovement>().enabled = true;

            GameObject.Find("Actif").GetComponentInChildren<PlayerMovement>().rb.freezeRotation = true;
            GameObject.Find("Inactif").GetComponentInChildren<PlayerMovement>().rb.freezeRotation = true;

            GameObject.Find("Actif").GetComponentInChildren<PlayerMovement>().transform.eulerAngles = new Vector3(0, 0, 0);
            GameObject.Find("Inactif").GetComponentInChildren<PlayerMovement>().transform.eulerAngles = new Vector3(0, 0, 0);
        }
    }

    void LateUpdate()
    {
        if (currentTime == 0)
        {
            Destroy(gameObject.GetComponent<ChronoMove>());
            gameObject.AddComponent<ChronoMove>();
            GameObject.Find("Actif").GetComponent<ChronoMove>().enabled = false;
            GameObject.Find("Inactif").GetComponent<ChronoMove>().enabled = false;
        }
    }


    void Reset()
    {
        currentTime = 4f;
    }
}
