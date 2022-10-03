using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MoneyController : MonoBehaviour
{
    int moneyAmount;
    public Text moneyAmountText;

    void Start()
    {
        moneyAmount = PlayerPrefs.GetInt("MoneyAmount");
    }

    void Update()
    {
        moneyAmountText.text = moneyAmount.ToString();
    }
}
