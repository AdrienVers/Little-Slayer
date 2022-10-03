using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActifDesactif : MonoBehaviour
{
    public GameObject Rouge;

    public void BecomeActif()
    {
        //Rouge.transform.parent = GameObject.Find("Actif").transform;
        //Rouge.GetComponentInChildren<Armes>().gameObject.SetActive(true); // Fonctionne
        Rouge.SetActive(true);
    }

    public void BecomeInactif()
    {
        //Rouge.transform.parent = GameObject.Find("Inactif").transform;
        //Rouge.GetComponentInChildren<Armes>().gameObject.SetActive(false); // Fonctionne
        Rouge.SetActive(false);
    }
}