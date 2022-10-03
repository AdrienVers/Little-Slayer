using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetPackActivation : MonoBehaviour
{
    void Start()
    { }

    void Update()
    {
        GameObject.Find("Actif").GetComponentInChildren<JetPackManager>().enabled = true;
        GameObject.Find("Actif").GetComponentInChildren<PlayerMovement>().enabled = false;

        /*
        if (GameObject.Find("Actif").GetComponentInChildren<JetPackManager>().enabled == false)
        {
            GameObject.Find("Actif").GetComponentInChildren<JetPackManager>().fuel = 300;
        }
        */
    }
}
