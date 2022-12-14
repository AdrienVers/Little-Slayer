using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructorLoot : MonoBehaviour
{
    public bool available1;
    public bool available2;
    public bool available3;
    public bool available4;

    public GameObject V1;
    public GameObject V2;
    public GameObject V3;
    public GameObject V4;

    public GameObject X1;
    public GameObject X2;
    public GameObject X3;
    public GameObject X4;

    //public Text AcierText;
    //public Text CuivreText;
    //public Text CharbonText;

    public int Acier;
    public int Cuivre;
    public int Charbon;
    public int Micro;

    void Start()
    {
        available1 = false;
        available2 = false;
        available3 = false;
        available4 = false;
    }


    void Update()
    {
        Acier = GameObject.Find("ShopManager").GetComponent<ShopController>().Acier;
        Cuivre = GameObject.Find("ShopManager").GetComponent<ShopController>().Cuivre;
        Charbon = GameObject.Find("ShopManager").GetComponent<ShopController>().Charbon;
        Micro = GameObject.Find("ShopManager").GetComponent<ShopController>().Micro;
    }

    void LateUpdate()
    {
        if (Acier >= 5)
        {
            available1 = true;
            V1.SetActive(true);
            X1.SetActive(false);
        }

        else if (Acier < 5)
        {
            available1 = false;
            V1.SetActive(false);
            X1.SetActive(true);
        }

        if (Cuivre >= 2)
        {
            available2 = true;
            V2.SetActive(true);
            X2.SetActive(false);
        }

        else if (Cuivre < 2)
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

        if (Micro > 0)
        {
            available4 = true;
            V4.SetActive(true);
            X4.SetActive(false);
        }

        else if (Micro == 0)
        {
            available4 = false;
            V4.SetActive(false);
            X4.SetActive(true);
        }
    }
}
