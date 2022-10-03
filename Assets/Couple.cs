using UnityEngine;

public class Couple : MonoBehaviour
{
    public GameObject Rouge;

    public void BecomeActif()
    {
        Rouge.transform.parent = GameObject.Find("Actif").transform;
    }

    public void BecomeInactif()
    {
        Rouge.transform.parent = GameObject.Find("Inactif").transform;
    }
}