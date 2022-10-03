using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModernActivation : MonoBehaviour
{
    public GameObject Bazooka;
    public GameObject MegaBazooka;
    public GameObject Pompe;
    public GameObject Pompamine;
    public GameObject Sniper;
    public GameObject Ventouseur;
    public GameObject Revolver;
    public GameObject Detresse;
    public GameObject Uzi;
    public GameObject Carabine;
    public GameObject Homing;
    public GameObject Destructor;
    public GameObject Laser;
    public GameObject Pistoglace;

    public void Bazooka1()
    {
        Bazooka.SetActive(true);
        MegaBazooka.SetActive(false);
        Pompe.SetActive(false);
        Pompamine.SetActive(false);
        Sniper.SetActive(false);
        Ventouseur.SetActive(false);
        Revolver.SetActive(false); 
        Detresse.SetActive(false);
        Uzi.SetActive(false);
        Carabine.SetActive(false);
        Homing.SetActive(false);
        Destructor.SetActive(false);
        Laser.SetActive(false);
        Pistoglace.SetActive(false);
    }

    public void MegaBazooka1()
    {
        Bazooka.SetActive(false);
        MegaBazooka.SetActive(true);
        Pompe.SetActive(false);
        Pompamine.SetActive(false);
        Sniper.SetActive(false);
        Ventouseur.SetActive(false);
        Revolver.SetActive(false);
        Detresse.SetActive(false);
        Uzi.SetActive(false);
        Carabine.SetActive(false);
        Homing.SetActive(false);
        Destructor.SetActive(false);
        Laser.SetActive(false);
        Pistoglace.SetActive(false);
    }

    public void Pompe1()
    {
        Bazooka.SetActive(false);
        MegaBazooka.SetActive(false);
        Pompe.SetActive(true);
        Pompamine.SetActive(false);
        Sniper.SetActive(false);
        Ventouseur.SetActive(false);
        Revolver.SetActive(false);
        Detresse.SetActive(false);
        Uzi.SetActive(false);
        Carabine.SetActive(false);
        Homing.SetActive(false);
        Destructor.SetActive(false);
        Laser.SetActive(false);
        Pistoglace.SetActive(false);
    }

    public void Pompamine1()
    {
        Bazooka.SetActive(false);
        MegaBazooka.SetActive(false);
        Pompe.SetActive(false);
        Pompamine.SetActive(true);
        Sniper.SetActive(false);
        Ventouseur.SetActive(false);
        Revolver.SetActive(false);
        Detresse.SetActive(false);
        Uzi.SetActive(false);
        Carabine.SetActive(false);
        Homing.SetActive(false);
        Destructor.SetActive(false);
        Laser.SetActive(false);
        Pistoglace.SetActive(false);
    }

    public void Revolver1()
    {
        Bazooka.SetActive(false);
        MegaBazooka.SetActive(false);
        Pompe.SetActive(false);
        Pompamine.SetActive(false);
        Sniper.SetActive(false);
        Ventouseur.SetActive(false);
        Revolver.SetActive(true);
        Detresse.SetActive(false);
        Uzi.SetActive(false);
        Carabine.SetActive(false);
        Homing.SetActive(false);
        Destructor.SetActive(false);
        Laser.SetActive(false);
        Pistoglace.SetActive(false);
    }

    public void Detresse1()
    {
        Bazooka.SetActive(false);
        MegaBazooka.SetActive(false);
        Pompe.SetActive(false);
        Pompamine.SetActive(false);
        Sniper.SetActive(false);
        Ventouseur.SetActive(false);
        Revolver.SetActive(false);
        Detresse.SetActive(true);
        Uzi.SetActive(false);
        Carabine.SetActive(false);
        Homing.SetActive(false);
        Destructor.SetActive(false);
        Laser.SetActive(false);
        Pistoglace.SetActive(false);
    }

    public void Uzi1()
    {
        Bazooka.SetActive(false);
        MegaBazooka.SetActive(false);
        Pompe.SetActive(false);
        Pompamine.SetActive(false);
        Sniper.SetActive(false);
        Ventouseur.SetActive(false);
        Revolver.SetActive(false);
        Detresse.SetActive(false);
        Uzi.SetActive(true);
        Carabine.SetActive(false);
        Homing.SetActive(false);
        Destructor.SetActive(false);
        Laser.SetActive(false);
        Pistoglace.SetActive(false);
    }

    public void Carabine1()
    {
        Bazooka.SetActive(false);
        MegaBazooka.SetActive(false);
        Pompe.SetActive(false);
        Pompamine.SetActive(false);
        Sniper.SetActive(false);
        Ventouseur.SetActive(false);
        Revolver.SetActive(false);
        Detresse.SetActive(false);
        Uzi.SetActive(false);
        Carabine.SetActive(true);
        Homing.SetActive(false);
        Destructor.SetActive(false);
        Laser.SetActive(false);
        Pistoglace.SetActive(false);
    }

    public void Homing1()
    {
        Bazooka.SetActive(false);
        MegaBazooka.SetActive(false);
        Pompe.SetActive(false);
        Pompamine.SetActive(false);
        Sniper.SetActive(false);
        Ventouseur.SetActive(false);
        Revolver.SetActive(false);
        Detresse.SetActive(false);
        Uzi.SetActive(false);
        Carabine.SetActive(false);
        Homing.SetActive(true);
        Destructor.SetActive(false);
        Laser.SetActive(false);
        Pistoglace.SetActive(false);
    }

    public void Destructor1()
    {
        Bazooka.SetActive(false);
        MegaBazooka.SetActive(false);
        Pompe.SetActive(false);
        Pompamine.SetActive(false);
        Sniper.SetActive(false);
        Ventouseur.SetActive(false);
        Revolver.SetActive(false);
        Detresse.SetActive(false);
        Uzi.SetActive(false);
        Carabine.SetActive(false);
        Homing.SetActive(false);
        Destructor.SetActive(true);
        Laser.SetActive(false);
        Pistoglace.SetActive(false);
    }

    public void Laser1()
    {
        Bazooka.SetActive(false);
        MegaBazooka.SetActive(false);
        Pompe.SetActive(false);
        Pompamine.SetActive(false);
        Sniper.SetActive(false);
        Ventouseur.SetActive(false);
        Revolver.SetActive(false);
        Detresse.SetActive(false);
        Uzi.SetActive(false);
        Carabine.SetActive(false);
        Homing.SetActive(false);
        Destructor.SetActive(false);
        Laser.SetActive(true);
        Pistoglace.SetActive(false);
    }

    public void Pistoglace1()
    {
        Bazooka.SetActive(false);
        MegaBazooka.SetActive(false);
        Pompe.SetActive(false);
        Pompamine.SetActive(false);
        Sniper.SetActive(false);
        Ventouseur.SetActive(false);
        Revolver.SetActive(false);
        Detresse.SetActive(false);
        Uzi.SetActive(false);
        Carabine.SetActive(false);
        Homing.SetActive(false);
        Destructor.SetActive(false);
        Laser.SetActive(false);
        Pistoglace.SetActive(true);
    }

    public void Sniper1()
    {
        Bazooka.SetActive(false);
        MegaBazooka.SetActive(false);
        Pompe.SetActive(false);
        Pompamine.SetActive(false);
        Sniper.SetActive(true);
        Ventouseur.SetActive(false);
        Revolver.SetActive(false);
        Detresse.SetActive(false);
        Uzi.SetActive(false);
        Carabine.SetActive(false);
        Homing.SetActive(false);
        Destructor.SetActive(false);
        Laser.SetActive(false);
        Pistoglace.SetActive(false);
    }

    public void Ventouseur1()
    {
        Bazooka.SetActive(false);
        MegaBazooka.SetActive(false);
        Pompe.SetActive(false);
        Pompamine.SetActive(false);
        Sniper.SetActive(false);
        Ventouseur.SetActive(true);
        Revolver.SetActive(false);
        Detresse.SetActive(false);
        Uzi.SetActive(false);
        Carabine.SetActive(false);
        Homing.SetActive(false);
        Destructor.SetActive(false);
        Laser.SetActive(false);
        Pistoglace.SetActive(false);
    }

}
