using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopController : MonoBehaviour
{
    int moneyAmount;

    public int Bois;
    public int Charbon;
    public int Verre;
    public int Plastique;

    public int Acier;
    public int Cuivre;
    public int Fer;
    public int Micro;

    int BazookaNumber;
    int Pompe;
    int Sniper;
    int Uzi;
    int Homing;
    int Destructor;

    public Text moneyAmountText;

    public Text BoisText;
    public Text CharbonText;
    public Text VerreText;
    public Text PlastiqueText;

    public Text AcierText;
    public Text CuivreText;
    public Text FerText;
    public Text MicroText;

    // Bazooka
    public Text CharbonBazooka;
    public Text AcierBazooka;
    public Text CuivreBazooka;

    // Pompe
    public Text CharbonPompe;
    public Text AcierPompe;
    public Text BoisPompe;

    // Sniper
    public Text CharbonSniper;
    public Text AcierSniper;
    public Text BoisSniper;
    public Text VerreSniper;

    // Uzi
    public Text AcierUzi;
    public Text FerUzi;
    public Text CharbonUzi;

    // Homing
    public Text AcierHoming;
    public Text CuivreHoming;
    public Text CharbonHoming;
    public Text MicroHoming;

    // Destructor
    public Text AcierDestructor;
    public Text CuivreDestructor;
    public Text CharbonDestructor;
    public Text MicroDestructor;


    public Text riflePrice;

    public Text NumberText;
    public Text PompeText;
    public Text SniperText;
    public Text UziText;
    public Text HomingText;
    public Text DestructorText;

    public Button buyButtonBazooka;
    public Button craftButtonBazooka;

    public Button buyButtonPompe;
    public Button craftButtonPompe;

    public Button buyButtonSniper;
    public Button craftButtonSniper;

    public Button buyButtonUzi;
    public Button craftButtonUzi;

    public Button buyButtonHoming;
    public Button craftButtonHoming;

    public Button buyButtonDestructor;
    public Button craftButtonDestructor;

    void Start()
    {
        moneyAmount = PlayerPrefs.GetInt("MoneyAmount");

        Bois = PlayerPrefs.GetInt("Bois");
        Charbon = PlayerPrefs.GetInt("Charbon");
        Verre = PlayerPrefs.GetInt("Verre");
        Plastique = PlayerPrefs.GetInt("Plastique");

        Acier = PlayerPrefs.GetInt("Acier");
        Cuivre = PlayerPrefs.GetInt("Cuivre");
        Fer = PlayerPrefs.GetInt("Fer");
        Micro = PlayerPrefs.GetInt("Micro");

        BazookaNumber = PlayerPrefs.GetInt("BazookaNumber");
        Pompe = PlayerPrefs.GetInt("Pompe");
        Sniper = PlayerPrefs.GetInt("Sniper");
        Uzi = PlayerPrefs.GetInt("Uzi");
        Homing = PlayerPrefs.GetInt("Homing");
        Destructor = PlayerPrefs.GetInt("Destructor");
    }

    void Update()
    {
        moneyAmountText.text = moneyAmount.ToString();

        BoisText.text = Bois.ToString();
        CharbonText.text = Charbon.ToString();
        VerreText.text = Verre.ToString();
        PlastiqueText.text = Plastique.ToString();

        AcierText.text = Acier.ToString();
        CuivreText.text = Cuivre.ToString();
        FerText.text = Fer.ToString();
        MicroText.text = Micro.ToString();

        // Bazooka
        AcierBazooka.text = Acier.ToString();
        CuivreBazooka.text = Cuivre.ToString();
        CharbonBazooka.text = Charbon.ToString();

        // Pompe
        AcierPompe.text = Acier.ToString();
        BoisPompe.text = Bois.ToString();
        CharbonPompe.text = Charbon.ToString();

        // Sniper
        AcierSniper.text = Acier.ToString();
        BoisSniper.text = Bois.ToString();
        CharbonSniper.text = Charbon.ToString();
        VerreSniper.text = Verre.ToString();

        // Uzi
        AcierUzi.text = Acier.ToString();
        FerUzi.text = Fer.ToString();
        CharbonUzi.text = Charbon.ToString();

        // Homing
        AcierHoming.text = Acier.ToString();
        CuivreHoming.text = Cuivre.ToString();
        CharbonHoming.text = Charbon.ToString();
        MicroHoming.text = Micro.ToString();

        // Destructor
        AcierDestructor.text = Acier.ToString();
        CuivreDestructor.text = Cuivre.ToString();
        CharbonDestructor.text = Charbon.ToString();
        MicroDestructor.text = Micro.ToString();


        NumberText.text = BazookaNumber.ToString();
        PompeText.text = Pompe.ToString();
        SniperText.text = Sniper.ToString();
        UziText.text = Uzi.ToString();
        HomingText.text = Homing.ToString();
        DestructorText.text = Destructor.ToString();

        // Bazooka
        if (moneyAmount >= 5)
        {
            buyButtonBazooka.interactable = true;
        }

        else
        {
            buyButtonBazooka.interactable = false;
        }

        if (Acier >= 1 && Cuivre >= 1 && Charbon >= 1)
        {
            craftButtonBazooka.interactable = true;
        }

        else
        {
            craftButtonBazooka.interactable = false;
        }

        // Pompe
        if (moneyAmount >= 5)
        {
            buyButtonPompe.interactable = true;
        }

        else
        {
            buyButtonPompe.interactable = false;
        }

        if (Acier >= 1 && Bois >= 1 && Charbon >= 1)
        {
            craftButtonPompe.interactable = true;
        }

        else
        {
            craftButtonPompe.interactable = false;
        }

        //Sniper
        if (moneyAmount >= 6)
        {
            buyButtonSniper.interactable = true;
        }

        else
        {
            buyButtonSniper.interactable = false;
        }

        if (Acier >= 1 && Bois >= 1 && Charbon >= 1 && Verre >= 1)
        {
            craftButtonSniper.interactable = true;
        }

        else
        {
            craftButtonSniper.interactable = false;
        }

        // Uzi

        if (moneyAmount >= 6)
        {
            buyButtonUzi.interactable = true;
        }

        else
        {
            buyButtonUzi.interactable = false;
        }

        if (Acier >= 1 && Fer >= 1 && Charbon >= 1)
        {
            craftButtonUzi.interactable = true;
        }

        else
        {
            craftButtonUzi.interactable = false;
        }

        // Homing

        if (moneyAmount >= 10)
        {
            buyButtonHoming.interactable = true;
        }

        else
        {
            buyButtonHoming.interactable = false;
        }

        if (Acier >= 1 && Cuivre >= 1 && Charbon >= 1 && Micro >= 1)
        {
            craftButtonHoming.interactable = true;
        }

        else
        {
            craftButtonHoming.interactable = false;
        }

        // Destructor

        if (moneyAmount >= 50)
        {
            buyButtonDestructor.interactable = true;
        }

        else
        {
            buyButtonDestructor.interactable = false;
        }

        if (Acier >= 5 && Cuivre >= 2 && Charbon >= 1 && Micro >= 1)
        {
            craftButtonDestructor.interactable = true;
        }

        else
        {
            craftButtonDestructor.interactable = false;
        }
    }

    // Bazooka
    public void buyRifle()
    {
        moneyAmount -= 5;
        BazookaNumber += 1;
    }

    public void craftRifle()
    {
        Acier -= 1;
        Cuivre -= 1;
        Charbon -= 1;
        BazookaNumber += 1;
    }

    // Pompe
    public void buyPompe()
    {
        moneyAmount -= 5;
        Pompe += 1;
    }

    public void craftPompe()
    {
        Acier -= 1;
        Bois -= 1;
        Charbon -= 1;
        Pompe += 1;
    }

    //Sniper
    public void buySniper()
    {
        moneyAmount -= 6;
        Sniper += 1;
    }

    public void craftSniper()
    {
        Acier -= 1;
        Bois -= 1;
        Charbon -= 1;
        Verre -= 1;
        Sniper += 1;
    }


    //Uzi
    public void buyUzi()
    {
        moneyAmount -= 4;
        Uzi += 1;
    }

    public void craftUzi()
    {
        Acier -= 1;
        Fer -= 1;
        Charbon -= 1;
        Uzi += 1;
    }

    //Homing
    public void buyHoming()
    {
        moneyAmount -= 10;
        Homing += 1;
    }

    public void craftHoming()
    {
        Acier -= 1;
        Cuivre -= 1;
        Charbon -= 1;
        Micro -= 1;
        Homing += 1;
    }

    //Destuctor
    public void buyDestructor()
    {
        moneyAmount -= 50;
        Destructor += 1;
    }

    public void craftDestructor()
    {
        Acier -= 1;
        Cuivre -= 1;
        Charbon -= 1;
        Micro -= 1;
        Destructor += 1;
    }


    public void exitShop()
    {
        PlayerPrefs.SetInt("MoneyAmount", moneyAmount);

        PlayerPrefs.SetInt("Bois", Bois);
        PlayerPrefs.SetInt("Charbon", Charbon);
        PlayerPrefs.SetInt("Verre", Verre);
        PlayerPrefs.SetInt("Plastique", Plastique);

        PlayerPrefs.SetInt("Acier", Acier);
        PlayerPrefs.SetInt("Cuivre", Cuivre);
        PlayerPrefs.SetInt("Fer", Fer);
        PlayerPrefs.SetInt("Micro", Micro);

        PlayerPrefs.SetInt("BazookaNumber", BazookaNumber);
        PlayerPrefs.SetInt("Pompe", Pompe);
        PlayerPrefs.SetInt("Sniper", Sniper);
        PlayerPrefs.SetInt("Uzi", Uzi);
        PlayerPrefs.SetInt("Homing", Homing);
        PlayerPrefs.SetInt("Destructor", Destructor);

        SceneManager.LoadScene("Ile-LV1");
    }

    public void Save()
    {
        PlayerPrefs.SetInt("MoneyAmount", moneyAmount);

        PlayerPrefs.SetInt("Bois", Bois);
        PlayerPrefs.SetInt("Charbon", Charbon);
        PlayerPrefs.SetInt("Verre", Verre);
        PlayerPrefs.SetInt("Plastique", Plastique);

        PlayerPrefs.SetInt("Acier", Acier);
        PlayerPrefs.SetInt("Cuivre", Cuivre);
        PlayerPrefs.SetInt("Fer", Fer);
        PlayerPrefs.SetInt("Micro", Micro);

        PlayerPrefs.SetInt("BazookaNumber", BazookaNumber);
        PlayerPrefs.SetInt("Pompe", Pompe);
        PlayerPrefs.SetInt("Sniper", Sniper);
        PlayerPrefs.SetInt("Uzi", Uzi);
        PlayerPrefs.SetInt("Homing", Homing);
        PlayerPrefs.SetInt("Destructor", Destructor);
    }

    public void resetPlayerPrefs()
    {
        moneyAmount = 0;
        BazookaNumber = 0;
        buyButtonBazooka.gameObject.SetActive(true);
        buyButtonPompe.gameObject.SetActive(true);
        buyButtonSniper.gameObject.SetActive(true);
        buyButtonUzi.gameObject.SetActive(true);
        buyButtonHoming.gameObject.SetActive(true);
        buyButtonDestructor.gameObject.SetActive(true);
        PlayerPrefs.DeleteAll();
    }



}
