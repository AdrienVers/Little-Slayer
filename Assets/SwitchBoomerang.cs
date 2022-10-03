using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchBoomerang : MonoBehaviour
{
    int activeWeapon = 1;

    void start()
    { }

    public void SwitchWpn()
    {
        switch (activeWeapon)
        {
            case 1:

                activeWeapon = 2;

                GameObject.Find("Actif").GetComponentInChildren<WeaponSwitcher>().Boomerang.gameObject.SetActive(true);

                // Armes Modernes

                GameObject.Find("Actif").GetComponentInChildren<WeaponSwitcher>().Bazooka.gameObject.SetActive(false);
                GameObject.Find("Actif").GetComponentInChildren<WeaponSwitcher>().Pompe.gameObject.SetActive(false);
                GameObject.Find("Actif").GetComponentInChildren<WeaponSwitcher>().Sniper.gameObject.SetActive(false);
                GameObject.Find("Actif").GetComponentInChildren<WeaponSwitcher>().Uzi.gameObject.SetActive(false);
                GameObject.Find("Actif").GetComponentInChildren<WeaponSwitcher>().Homing.gameObject.SetActive(false);

                // Armes Diffusion

                GameObject.Find("Actif").GetComponentInChildren<WeaponSwitcher>().LanceFlamme.gameObject.SetActive(false);
                GameObject.Find("Actif").GetComponentInChildren<WeaponSwitcher>().Extincteur.gameObject.SetActive(false);

                // Armes Explosives

                GameObject.Find("Actif").GetComponentInChildren<WeaponSwitcher>().Grenade.gameObject.SetActive(false);
                GameObject.Find("Actif").GetComponentInChildren<WeaponSwitcher>().Mine.gameObject.SetActive(false);


                // Armes Bestiales

                GameObject.Find("Actif").GetComponentInChildren<WeaponSwitcher>().Requin.gameObject.SetActive(false);
                GameObject.Find("Actif").GetComponentInChildren<WeaponSwitcher>().Raptor.gameObject.SetActive(false);

                // Moyens Déplacement

                GameObject.Find("Actif").GetComponentInChildren<WeaponSwitcher>().JetPack.gameObject.SetActive(false);

                // Armes Ancestrales 

                GameObject.Find("Actif").GetComponentInChildren<WeaponSwitcher>().Arc.gameObject.SetActive(false);
                GameObject.Find("Actif").GetComponentInChildren<WeaponSwitcher>().Shuriken.gameObject.SetActive(false);

                // Armes Corps à Corps

                GameObject.Find("Actif").GetComponentInChildren<WeaponSwitcher>().Batte.gameObject.SetActive(false);
                GameObject.Find("Actif").GetComponentInChildren<WeaponSwitcher>().Canne.gameObject.SetActive(false);

                // Armes Aériennes 

                GameObject.Find("Actif").GetComponentInChildren<WeaponSwitcher>().Pot.gameObject.SetActive(false);
                GameObject.Find("Actif").GetComponentInChildren<WeaponSwitcher>().BombeA.gameObject.SetActive(false);

                // Armes Funs

                //GameObject.Find("Actif").GetComponentInChildren<WeaponSwitcher>().Boomerang.gameObject.SetActive(false);

                // Tourelles

                GameObject.Find("Actif").GetComponentInChildren<WeaponSwitcher>().Mono.gameObject.SetActive(false);

                break;

            case 2:

                activeWeapon = 1;

                GameObject.Find("Actif").GetComponentInChildren<WeaponSwitcher>().Boomerang.gameObject.SetActive(true);

                // Armes Modernes

                GameObject.Find("Actif").GetComponentInChildren<WeaponSwitcher>().Bazooka.gameObject.SetActive(false);
                GameObject.Find("Actif").GetComponentInChildren<WeaponSwitcher>().Pompe.gameObject.SetActive(false);
                GameObject.Find("Actif").GetComponentInChildren<WeaponSwitcher>().Sniper.gameObject.SetActive(false);
                GameObject.Find("Actif").GetComponentInChildren<WeaponSwitcher>().Uzi.gameObject.SetActive(false);
                GameObject.Find("Actif").GetComponentInChildren<WeaponSwitcher>().Homing.gameObject.SetActive(false);

                // Armes Diffusion

                GameObject.Find("Actif").GetComponentInChildren<WeaponSwitcher>().LanceFlamme.gameObject.SetActive(false);
                GameObject.Find("Actif").GetComponentInChildren<WeaponSwitcher>().Extincteur.gameObject.SetActive(false);

                // Armes Explosives

                GameObject.Find("Actif").GetComponentInChildren<WeaponSwitcher>().Grenade.gameObject.SetActive(false);
                GameObject.Find("Actif").GetComponentInChildren<WeaponSwitcher>().Mine.gameObject.SetActive(false);


                // Armes Bestiales

                GameObject.Find("Actif").GetComponentInChildren<WeaponSwitcher>().Requin.gameObject.SetActive(false);
                GameObject.Find("Actif").GetComponentInChildren<WeaponSwitcher>().Raptor.gameObject.SetActive(false);

                // Moyens Déplacement

                GameObject.Find("Actif").GetComponentInChildren<WeaponSwitcher>().JetPack.gameObject.SetActive(false);

                // Armes Ancestrales 

                GameObject.Find("Actif").GetComponentInChildren<WeaponSwitcher>().Arc.gameObject.SetActive(false);
                GameObject.Find("Actif").GetComponentInChildren<WeaponSwitcher>().Shuriken.gameObject.SetActive(false);

                // Armes Corps à Corps

                GameObject.Find("Actif").GetComponentInChildren<WeaponSwitcher>().Batte.gameObject.SetActive(false);
                GameObject.Find("Actif").GetComponentInChildren<WeaponSwitcher>().Canne.gameObject.SetActive(false);

                // Armes Aériennes 

                GameObject.Find("Actif").GetComponentInChildren<WeaponSwitcher>().Pot.gameObject.SetActive(false);
                GameObject.Find("Actif").GetComponentInChildren<WeaponSwitcher>().BombeA.gameObject.SetActive(false);

                // Armes Funs

                //GameObject.Find("Actif").GetComponentInChildren<WeaponSwitcher>().Boomerang.gameObject.SetActive(false);

                // Tourelles

                GameObject.Find("Actif").GetComponentInChildren<WeaponSwitcher>().Mono.gameObject.SetActive(false);

                break;
        }
    }
}