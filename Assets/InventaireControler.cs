using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InventaireControler : MonoBehaviour
{
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

    public static int Bois;
    public static int Charbon;
    public static int Verre;
    public static int Plastique;

    public static int Acier;
    public static int Cuivre;
    public static int Fer;
    public static int Micro;

    public static int Viande;
    public static int Sang;
    public static int Peau;
    public static int Poisson;

    public static int Nuage;
    public static int Eau;
    public static int Glace;
    public static int Etoile;

    public static int Roche;
    public static int Racine;
    public static int Fossile;
    public static int Uranium;

    public static int moneyAmount;
    public static int BazookaNumber;

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

    public void gotoShop()
    {
        PlayerPrefs.SetInt("Bois", Bois);
        PlayerPrefs.SetInt("Charbon", Charbon);
        PlayerPrefs.SetInt("Verre", Verre);
        PlayerPrefs.SetInt("Plastique", Plastique);

        PlayerPrefs.SetInt("Acier", Acier);
        PlayerPrefs.SetInt("Cuivre", Cuivre);
        PlayerPrefs.SetInt("Fer", Fer);
        PlayerPrefs.SetInt("Micro", Micro);

        PlayerPrefs.SetInt("Viande", Viande);
        PlayerPrefs.SetInt("Sang", Sang);
        PlayerPrefs.SetInt("Peau", Peau);
        PlayerPrefs.SetInt("Poisson", Poisson);

        PlayerPrefs.SetInt("Nuage", Nuage);
        PlayerPrefs.SetInt("Eau", Eau);
        PlayerPrefs.SetInt("Glace", Glace);
        PlayerPrefs.SetInt("Etoile", Etoile);

        PlayerPrefs.SetInt("Roche", Roche);
        PlayerPrefs.SetInt("Racine", Racine);
        PlayerPrefs.SetInt("Fossile", Fossile);
        PlayerPrefs.SetInt("Uranium", Uranium);

        SceneManager.LoadScene("WeaponShop");
    }

}
