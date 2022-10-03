using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RewardsLoad : MonoBehaviour
{
    public string GoToRewards;
    public string RewardParis;
    public string RewardIle;
    public string MenuPrincipal;

    public void Rewards()
    {
        SceneManager.LoadScene(GoToRewards);
    }

    public void RewardsParis()
    {
        SceneManager.LoadScene(RewardParis);
    }

    public void RewardsIle()
    {
        SceneManager.LoadScene(RewardIle);
    }

    public void Menu()
    {
        SceneManager.LoadScene(MenuPrincipal);
    }
}

