using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGamesLoad : MonoBehaviour
{
    public string MiniGames;
    public string Menu;

    public void MiniGame()
    {
        SceneManager.LoadScene(MiniGames);
    }

    public void RetourMenu()
    {
        SceneManager.LoadScene(Menu);
    }
}
