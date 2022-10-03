using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jouer : MonoBehaviour
{
    public string ChangeLevel;

    public void StartGame()
    {
        SceneManager.LoadScene(ChangeLevel);
    }
}
