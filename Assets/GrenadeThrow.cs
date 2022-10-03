using Destructible2D;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeThrow : MonoBehaviour
{
	public GameObject ExplosionEffect;
	public GameObject DetectionMechant;
	public GameObject DetectionPlayer;

	public bool Mechant30 = false;
	public bool Player30 = false;


	void Update()
	{
		//int distancex = Mathf.Abs(Mathf.RoundToInt(GameObject.Find("Inactif").transform.position.x - transform.position.x));
		//int distancey = Mathf.Abs(Mathf.RoundToInt(GameObject.Find("Inactif").transform.position.y - transform.position.y));

		int distancex = Mathf.Abs(Mathf.RoundToInt(GameObject.Find("Inactif").GetComponentInChildren <PlayerMovement>().transform.position.x - transform.position.x));
		int distancey = Mathf.Abs(Mathf.RoundToInt(GameObject.Find("Inactif").GetComponentInChildren<PlayerMovement>().transform.position.y - transform.position.y));

		if (distancex <= 5 && distancex >= 0 && distancey <= 5 && distancey >= 0)
		{
			DetectionMechant.GetComponent<SpriteRenderer>().color = Color.red;
			Mechant30 = true;
		}

		else
		{
			DetectionMechant.GetComponent<SpriteRenderer>().color = Color.green;
			Mechant30 = false;
		}

		//int Distancex = Mathf.Abs(Mathf.RoundToInt(GameObject.Find("Actif").transform.position.x - transform.position.x));
		//int Distancey = Mathf.Abs(Mathf.RoundToInt(GameObject.Find("Actif").transform.position.y - transform.position.y));

		int Distancex = Mathf.Abs(Mathf.RoundToInt(GameObject.Find("Actif").GetComponentInChildren<PlayerMovement>().transform.position.x - transform.position.x));
		int Distancey = Mathf.Abs(Mathf.RoundToInt(GameObject.Find("Actif").GetComponentInChildren<PlayerMovement>().transform.position.y - transform.position.y));

		if (Distancex <= 5 && Distancex >= 0 && Distancey <= 5 && Distancey >= 0)
		{
			DetectionPlayer.GetComponent<SpriteRenderer>().color = Color.red;
			Player30 = true;
		}

		else
		{
			DetectionPlayer.GetComponent<SpriteRenderer>().color = Color.green;
			Player30 = false;
		}

		if (GetComponentInChildren<GrenadeTimer>().currentTime == 0)
		{
			if (Mechant30 == true)
			{
				GameObject.Find("Inactif").GetComponentInChildren<PlayerMovement>().enabled = false;
				GameObject.Find("Inactif").GetComponentInChildren<PlayerMovement>().rb.freezeRotation = false;
				GameObject.Find("Inactif").GetComponent<ChronoMove>().enabled = true;
				GameObject.Find("Inactif").GetComponentInChildren<HPBar>().HP = GameObject.Find("Inactif").GetComponentInChildren<HPBar>().HP - 30;
			}


			if (Player30 == true)
			{
				GameObject.Find("Actif").GetComponentInChildren<PlayerMovement>().enabled = false;
				GameObject.Find("Actif").GetComponentInChildren<PlayerMovement>().rb.freezeRotation = false;
				GameObject.Find("Actif").GetComponent<ChronoMove>().enabled = true;
				GameObject.Find("Actif").GetComponentInChildren<HPBar>().HP = GameObject.Find("Actif").GetComponentInChildren<HPBar>().HP - 30;
			}

			GameObject ExplosionEffectIns = Instantiate(ExplosionEffect, transform.position, Quaternion.identity);
			Destroy(ExplosionEffectIns, 10);
			Destroy(gameObject);
		}

	}
}
