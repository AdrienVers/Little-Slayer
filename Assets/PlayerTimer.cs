using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTimer : MonoBehaviour
{
    public float currentTime = 0f;
    float startingTime = 19f;
    float transitionTime = 5f;

    public Text countdownText;
    public GameObject AlarmLight;
    public GameObject AlarmLightTransition;

    public GameObject Rouge;
    public GameObject Bleu;

    public GameObject ArmesR;
    public GameObject ArmesB;

    public GameObject JetPackR;
    public GameObject JetPackB;

    public GameObject Actif;
    public GameObject Inactif;

    public float BleuActif;
    public float RougeActif;

    /*
    public GameObject Jaune;
    public GameObject Vert;
    public GameObject Rose;
    public GameObject BleuClair;
    */


    void Awake()
    {
        currentTime = startingTime;
        AlarmLight.GetComponent<Image>().color = Color.red;

        ArmesR.SetActive(true);
        Rouge.GetComponent<PlayerMovement>().enabled = true;
        RougeActif = 1;

        ArmesB.SetActive(false);
        Bleu.GetComponent<PlayerMovement>().enabled = false;
        BleuActif = 0;
    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        if (AlarmLight.GetComponent<Image>().color == Color.red && currentTime <= 0) // Passage du Rouge au Bleu
        {
            currentTime = 19;
            startingTime = 19;
            AlarmLight.GetComponent<Image>().color = Color.blue;

            Rouge.transform.parent = GameObject.Find("Inactif").transform;
            Bleu.transform.parent = GameObject.Find("Actif").transform;

            ArmesR.SetActive(false);
            Rouge.GetComponent<PlayerMovement>().enabled = false;
            Rouge.GetComponent<JetPackManager>().enabled = false;
            JetPackR.SetActive(false);
            RougeActif = 0;

            ArmesB.SetActive(true);
            Bleu.GetComponent<PlayerMovement>().enabled = true;
            Bleu.GetComponent<JetPackManager>().enabled = false;
            JetPackB.SetActive(false);
            BleuActif = 1;
        }

        else if (AlarmLight.GetComponent<Image>().color == Color.blue) // Passage du Bleu au Rouge
        {
            if (currentTime <= 0)
            {
                currentTime = 19;
                startingTime = 19;
                AlarmLight.GetComponent<Image>().color = Color.red;

                Bleu.transform.parent = GameObject.Find("Inactif").transform;
                Rouge.transform.parent = GameObject.Find("Actif").transform;

                ArmesR.SetActive(true);
                Rouge.GetComponent<PlayerMovement>().enabled = true;
                Rouge.GetComponent<JetPackManager>().enabled = false;
                JetPackR.SetActive(false);

                RougeActif = 1;

                ArmesB.SetActive(false);
                Bleu.GetComponent<PlayerMovement>().enabled = false; // Code
                Bleu.GetComponent<JetPackManager>().enabled = false;
                JetPackR.SetActive(false);
                BleuActif = 0;
            }
        }

        if (Actif.GetComponentInChildren<PlayerMovement>().Auprochain == true)
        {
            currentTime = transitionTime; // 5s

            if (Rouge.transform.parent == GameObject.Find("Actif").transform)
            {
                AlarmLightTransition.GetComponent<Image>().color = Color.red;
                Actif.GetComponentInChildren<PlayerMovement>().Auprochain = false;
                Actif.GetComponent<JetPackManager>().enabled = false;
                //AlarmLightTransition.GetComponent<Image>().color = Color.white;
            }

            if (Bleu.transform.parent == GameObject.Find("Actif").transform)
            {
                AlarmLightTransition.GetComponent<Image>().color = Color.blue;
                Actif.GetComponentInChildren<PlayerMovement>().Auprochain = false;
                Actif.GetComponent<JetPackManager>().enabled = false;
                //AlarmLightTransition.GetComponent<Image>().color = Color.white;
            }
        }

        if (currentTime == 19)
        {
            AlarmLightTransition.GetComponent<Image>().color = Color.white;
        }
    }
}
