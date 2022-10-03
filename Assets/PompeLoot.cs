using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PompeLoot : MonoBehaviour
{
    public bool available1;
    public bool available2;
    public bool available3;

    public GameObject V1;
    public GameObject V2;
    public GameObject V3;
    public GameObject X1;
    public GameObject X2;
    public GameObject X3;

    //public Text AcierText;
    //public Text CuivreText;
    //public Text CharbonText;

    public int Acier;
    public int Bois;
    public int Charbon;

    void Start()
    {
        available1 = false;
        available2 = false;
        available3 = false;
    }


    void Update()
    {
        Acier = GameObject.Find("ShopManager").GetComponent<ShopController>().Acier;
        Bois = GameObject.Find("ShopManager").GetComponent<ShopController>().Bois;
        Charbon = GameObject.Find("ShopManager").GetComponent<ShopController>().Charbon;
    }

    void LateUpdate()
    {
        if (Acier > 0)
        {
            available1 = true;
            V1.SetActive(true);
            X1.SetActive(false);
        }

        else if (Acier == 0)
        {
            available1 = false;
            V1.SetActive(false);
            X1.SetActive(true);
        }

        if (Bois > 0)
        {
            available2 = true;
            V2.SetActive(true);
            X2.SetActive(false);
        }

        else if (Bois == 0)
        {
            available2 = false;
            V2.SetActive(false);
            X2.SetActive(true);
        }

        if (Charbon > 0)
        {
            available3 = true;
            V3.SetActive(true);
            X3.SetActive(false);
        }

        else if (Charbon == 0)
        {
            available3 = false;
            V3.SetActive(false);
            X3.SetActive(true);
        }
    }
}