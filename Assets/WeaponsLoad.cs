using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WeaponsLoad : MonoBehaviour
{
    public string Weapons;
    public string Ancestrales;
    public string Modernes;
    public string Explosives;
    public string Aeriennes;

    public void Weapon()
    {
        SceneManager.LoadScene(Weapons);
    }

    public void Ancestrale()
    {
        SceneManager.LoadScene(Ancestrales);
    }

    public void Moderne()
    {
        SceneManager.LoadScene(Modernes);
    }

    public void Explosive()
    {
        SceneManager.LoadScene(Explosives);
    }

    public void Aeriene()
    {
        SceneManager.LoadScene(Aeriennes);
    }
}