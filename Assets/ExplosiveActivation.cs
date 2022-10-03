using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosiveActivation : MonoBehaviour
{
    public GameObject Grenade;
    public GameObject Grenades;
    public GameObject Mine;
    public GameObject MineMarine;
    public GameObject Bombe;
    public GameObject Bowling;
    public GameObject Cocktail;
    public GameObject Detresse;
    public GameObject Uzi;
    public GameObject Carabine;
    public GameObject Homing;
    public GameObject Destructor;
    public GameObject Laser;
    public GameObject Pistoglace;

    public void Grenade1()
    {
        Grenade.SetActive(true);
        Grenades.SetActive(false);
        Mine.SetActive(false);
        MineMarine.SetActive(false);
        Bombe.SetActive(false);
        Bowling.SetActive(false);
        Cocktail.SetActive(false);
        Detresse.SetActive(false);
        Uzi.SetActive(false);
        Carabine.SetActive(false);
        Homing.SetActive(false);
        Destructor.SetActive(false);
        Laser.SetActive(false);
        Pistoglace.SetActive(false);
    }


    public void Mine1()
    {
        Grenade.SetActive(false);
        Grenades.SetActive(false);
        Mine.SetActive(true);
        MineMarine.SetActive(false);
        Bombe.SetActive(false);
        Bowling.SetActive(false);
        Cocktail.SetActive(false);
        Detresse.SetActive(false);
        Uzi.SetActive(false);
        Carabine.SetActive(false);
        Homing.SetActive(false);
        Destructor.SetActive(false);
        Laser.SetActive(false);
        Pistoglace.SetActive(false);
    }



    public void Cocktail1()
    {
        Grenade.SetActive(false);
        Grenades.SetActive(false);
        Mine.SetActive(false);
        MineMarine.SetActive(false);
        Bombe.SetActive(false);
        Bowling.SetActive(false);
        Cocktail.SetActive(true);
        Detresse.SetActive(false);
        Uzi.SetActive(false);
        Carabine.SetActive(false);
        Homing.SetActive(false);
        Destructor.SetActive(false);
        Laser.SetActive(false);
        Pistoglace.SetActive(false);
    }
}
