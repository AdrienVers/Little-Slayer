using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NuclearSpawner : MonoBehaviour
{
    public GameObject NuclearBomb;

    void Spawn(Vector3 position)
    {
        Instantiate(NuclearBomb).transform.position = position;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition, Camera.MonoOrStereoscopicEye.Mono);

            Vector3 adjustZ = new Vector3(worldPoint.x, worldPoint.y, NuclearBomb.transform.position.z);
            Spawn(adjustZ);
        }
    }
}

