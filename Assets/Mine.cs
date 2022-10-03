using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : MonoBehaviour
{
	public GameObject ExplosionEffect;
	public LayerMask LayerToHit;
	bool hasHit = false;
	bool hasHitRouge = false;
	bool hasHitBleu = false;

	void Start()
	{ }

	void Update()
	{
		if (hasHit)
		{
			//GameObject.Find("Actif").GetComponentInChildren<PlayerMovement>().enabled = false;
			GameObject.Find("Actif").GetComponentInChildren<PlayerMovement>().enabled = false;
			GameObject.Find("Actif").GetComponentInChildren<PlayerMovement>().rb.freezeRotation = false;

			GameObject.Find("Inactif").GetComponentInChildren<PlayerMovement>().enabled = false;
			GameObject.Find("Inactif").GetComponentInChildren<PlayerMovement>().rb.freezeRotation = false;

			GameObject.Find("Actif").GetComponentInChildren<ChronoMove>().enabled = true;
			GameObject.Find("Inactif").GetComponentInChildren<ChronoMove>().enabled = true;

			if (hasHitRouge)
			{
				GameObject.Find("Rouge").GetComponent<HPBar>().HP = GameObject.Find("Rouge").GetComponent<HPBar>().HP - 20;
			}

			else if (hasHitBleu)
			{
				GameObject.Find("Bleu").GetComponent<HPBar>().HP = GameObject.Find("Bleu").GetComponent<HPBar>().HP - 20;
			}
			
			GameObject ExplosionEffectIns = Instantiate(ExplosionEffect, transform.position, Quaternion.identity);
			Destroy(ExplosionEffectIns, 10);
			Destroy(gameObject);
		}
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (!hasHit)
		{
			/*
			if (col.gameObject.tag == "Player")
			{
				hasHit = true;
				hasHitPlayer = true;
			}


			else if (col.gameObject.tag == "Player")
			{
				hasHit = true;
				hasHitMechant = true;
			}
			*/

			if (col.gameObject.name == "Rouge")
			{
				hasHit = true;
				hasHitRouge = true;
			}

			else if (col.gameObject.name == "Bleu")
			{
				hasHit = true;
				hasHitBleu = true;
			}

		}
	}
}
