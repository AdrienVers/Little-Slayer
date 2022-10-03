using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameControler : MonoBehaviour
{
    public Text moneyText;
    public Text BazookaNumberText;
    public Text PompeText;
    public Text SniperText;
    public Text UziText;
    public Text HomingText;
    public Text DestructorText;

    public static int moneyAmount;
    public static int BazookaNumber;
    public static int Pompe;
    public static int Sniper;
    public static int Uzi;
    public static int Homing;
    public static int Destructor;

    void Start()
    {
        moneyAmount = PlayerPrefs.GetInt("MoneyAmount");
        BazookaNumber = PlayerPrefs.GetInt("BazookaNumber");
        Pompe = PlayerPrefs.GetInt("Pompe");
        Sniper = PlayerPrefs.GetInt("Sniper");
        Uzi = PlayerPrefs.GetInt("Uzi");
        Homing = PlayerPrefs.GetInt("Homing");
        Destructor = PlayerPrefs.GetInt("Destructor");
    }

    void Update()
    {
        moneyText.text = moneyAmount.ToString();
        BazookaNumberText.text = BazookaNumber.ToString();
        PompeText.text = Pompe.ToString();
        SniperText.text = Sniper.ToString();
        UziText.text = Uzi.ToString();
        HomingText.text = Homing.ToString();
        DestructorText.text = Destructor.ToString();
    }

    public void gotoShop()
    {
        PlayerPrefs.SetInt("MoneyAmount", moneyAmount);
        PlayerPrefs.SetInt("BazookaNumber", BazookaNumber);
        PlayerPrefs.SetInt("Pompe", Pompe);
        PlayerPrefs.SetInt("Sniper", Sniper);
        PlayerPrefs.SetInt("Uzir", BazookaNumber);
        PlayerPrefs.SetInt("Homing", Pompe);
        PlayerPrefs.SetInt("Destructor", Sniper);
        SceneManager.LoadScene("WeaponShop");
    }
}
