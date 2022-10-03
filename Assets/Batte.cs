using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Batte : MonoBehaviour
{
	public GameObject ExplosionEffect;
	public LayerMask LayerToHit;
	bool hasHit = false;
	bool hasHitMechant = false;
	bool hasHitPlayer = false;

	public float Puissance;

	void Start()
	{ }

	void Update()
	{
		if (hasHit)
		{
			GameObject.Find("Inactif").GetComponentInChildren<Rigidbody2D>().freezeRotation = false;
			//GameObject.Find("Inactif").GetComponentInChildren<Rigidbody2D>().AddForce(Vector3.right * Puissance);
			GameObject.Find("Inactif").GetComponentInChildren<ChronoMove>().enabled = true;


			if (GetComponentInParent<PlayerMovement>().transform.localScale.x == 1)
			{
				GameObject.Find("Inactif").GetComponentInChildren<Rigidbody2D>().AddForce(Vector3.right * Puissance);
			}


			if (GetComponentInParent<PlayerMovement>().transform.localScale.x == -1)
			{
				GameObject.Find("Inactif").GetComponentInChildren<Rigidbody2D>().AddForce(Vector3.right * -Puissance);
			}


			if (hasHitMechant)
			{
				GameObject.Find("Inactif").GetComponentInChildren<HPBar>().HP = GameObject.Find("Inactif").GetComponentInChildren<HPBar>().HP - 20;
			}

			GameObject ExplosionEffectIns = Instantiate(ExplosionEffect, transform.position, Quaternion.identity);
			Destroy(ExplosionEffectIns, 10);
			GetComponent<Batte>().enabled = false;
			//GetComponent<PolygonCollider2D>().enabled = false;
			//Destroy(GetComponent<PolygonCollider2D>());
		}
	}

	void OnTriggerStay2D(Collider2D collision)
	{
		if (!hasHit)
		{
			if (collision.gameObject.tag == "Player")
			{
				hasHit = true;
				hasHitPlayer = true;
				hasHitMechant = true;
			}
		}
	}

	/*
	void OnCollisionEnter2D(Collision2D col)
	{
		if (!hasHit)
		{
			if (col.gameObject.tag == "Player")
			{
				hasHit = true;
				//hasHitPlayer = true;
				hasHitMechant = true;
			}
			/*
			else if (col.gameObject.tag == "Player")
			{
				hasHit = true;
				hasHitPlayer = true;
			}
			
		}
	}
	*/
}
