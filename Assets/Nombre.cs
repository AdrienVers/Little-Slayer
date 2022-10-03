using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nombre : MonoBehaviour
{
    public GameObject Couleur;

    public Color Orange;
    public Color Vert;

    public Text nombreText;

    void Start()
    {
    }

    void Update()
    {
        
        if (nombreText.text == 0.ToString())
        {
            Couleur.GetComponent<Image>().color = Orange;
        }

        else 
        {
            Couleur.GetComponent<Image>().color = Vert;
        }

    }
}
