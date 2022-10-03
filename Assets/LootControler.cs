using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LootControler : MonoBehaviour
{
    int Bois;
    int Charbon;
    int Verre;
    int Plastique;

    int Acier;
    int Cuivre;
    int Fer;
    int Micro;

    int Viande;
    int Sang;
    int Peau;
    int Poisson;

    int Nuage;
    int Eau;
    int Glace;
    int Etoile;

    int Roche;
    int Racine;
    int Fossile;
    int Uranium;

    public Text BoisText;
    public Text CharbonText;
    public Text VerreText;
    public Text PlastiqueText;

    public Text AcierText;
    public Text CuivreText;
    public Text FerText;
    public Text MicroText;

    public Text ViandeText;
    public Text SangText;
    public Text PeauText;
    public Text PoissonText;

    public Text NuageText;
    public Text EauText;
    public Text GlaceText;
    public Text EtoileText;

    public Text RocheText;
    public Text RacineText;
    public Text FossileText;
    public Text UraniumText;

    void Start()
    {
        Bois = PlayerPrefs.GetInt("Bois");
        Charbon = PlayerPrefs.GetInt("Charbon");
        Verre = PlayerPrefs.GetInt("Verre");
        Plastique = PlayerPrefs.GetInt("Plastique");

        Acier = PlayerPrefs.GetInt("Acier");
        Cuivre = PlayerPrefs.GetInt("Cuivre");
        Fer = PlayerPrefs.GetInt("Fer");
        Micro = PlayerPrefs.GetInt("Micro");

        Viande = PlayerPrefs.GetInt("Viande");
        Sang = PlayerPrefs.GetInt("Sang");
        Peau = PlayerPrefs.GetInt("Peau");
        Poisson = PlayerPrefs.GetInt("Poisson");

        Nuage = PlayerPrefs.GetInt("Nuage");
        Eau = PlayerPrefs.GetInt("Eau");
        Glace = PlayerPrefs.GetInt("Glace");
        Etoile = PlayerPrefs.GetInt("Etoile");

        Roche = PlayerPrefs.GetInt("Roche");
        Racine = PlayerPrefs.GetInt("Racine");
        Fossile = PlayerPrefs.GetInt("Fossile");
        Uranium = PlayerPrefs.GetInt("Uranium");
    }


    void Update()
    {
        BoisText.text = Bois.ToString();
        CharbonText.text = Charbon.ToString();
        VerreText.text = Verre.ToString();
        PlastiqueText.text = Plastique.ToString();
        
        AcierText.text = Acier.ToString();
        CuivreText.text = Cuivre.ToString();
        FerText.text = Fer.ToString();
        MicroText.text = Micro.ToString();

        ViandeText.text = Viande.ToString();
        SangText.text = Sang.ToString();
        PeauText.text = Peau.ToString();
        PoissonText.text = Poisson.ToString();

        NuageText.text = Nuage.ToString();
        EauText.text = Eau.ToString();
        GlaceText.text = Glace.ToString();
        EtoileText.text = Etoile.ToString();

        RocheText.text = Roche.ToString();
        RacineText.text = Racine.ToString();
        FossileText.text = Fossile.ToString();
        UraniumText.text = Uranium.ToString();

    }

    public void resetPlayerPrefs()
    {
        Bois = 0;
        Charbon = 0;
        Verre = 0;
        Plastique = 0;

        Acier = 0;
        Cuivre = 0;
        Fer = 0;
        Micro = 0;

        Viande = 0;
        Sang = 0;
        Peau = 0;
        Poisson = 0;

        Nuage = 0;
        Eau = 0;
        Glace = 0;
        Etoile = 0;

        Roche = 0;
        Racine = 0;
        Fossile = 0;
        Uranium = 0;

        PlayerPrefs.DeleteAll();
    }
}
