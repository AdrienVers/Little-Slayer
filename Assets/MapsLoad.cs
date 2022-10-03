using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapsLoad : MonoBehaviour
{
    public string Maps;
    public string MapsParis;
    public string MapsIle;
    public string I1;
    public string Menu;

    public void Map()
    {
        SceneManager.LoadScene(Maps);
    }

    public void Paris()
    {
        SceneManager.LoadScene(MapsParis);
    }

    public void Ile()
    {
        SceneManager.LoadScene(MapsIle);
    }

    public void Ile1()
    {
        SceneManager.LoadScene(I1);
    }

    public void RetourMenu()
    {
        SceneManager.LoadScene(Menu);
    }
}
