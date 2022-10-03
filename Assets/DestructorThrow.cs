﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructorThrow : MonoBehaviour
{
	Rigidbody2D rb;
	public float speed;
	bool hasHit = false;

	public int counter;

	public float fieldoImpact;
	public float force;
	public GameObject ExplosionEffect;
	public LayerMask LayerToHit;

	public GameObject DetectionMechant;
	public GameObject DetectionPlayer;

	public bool Mechant30 = false;
	public bool Player30 = false;

	public float currentTime = 0f;
	float startingTime = 4f;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		rb.velocity = transform.right * speed;
		currentTime = startingTime;
		//counter = 20;
	}

	void Update()
	{
		currentTime -= 1 * Time.deltaTime;

		if (currentTime <= 0)
		{
			currentTime = 0;
		}

		int distancex = Mathf.Abs(Mathf.RoundToInt(GameObject.Find("Inactif").GetComponentInChildren<PlayerMovement>().transform.position.x - transform.position.x));
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

		if (hasHit)
		{
			speed = 28;
			rb.velocity = transform.right * speed;
			counter -= 1;

			explode();
			GameObject ExplosionEffectIns = Instantiate(ExplosionEffect, transform.position, Quaternion.identity);
			Destroy(ExplosionEffectIns, 10);
			//Destroy(gameObject);

			if (Mechant30 == true)
			{
				GameObject.Find("Inactif").GetComponentInChildren<PlayerMovement>().enabled = false;
				GameObject.Find("Inactif").GetComponentInChildren<PlayerMovement>().rb.freezeRotation = false;
				GameObject.Find("Inactif").GetComponent<ChronoMove>().enabled = true;
				//GameObject.Find("Inactif").GetComponentInChildren<HPBar>().HP = GameObject.Find("Inactif").GetComponentInChildren<HPBar>().HP - 10;
			}

			if (Player30 == true)
			{
				GameObject.Find("Actif").GetComponentInChildren<PlayerMovement>().enabled = false;
				GameObject.Find("Actif").GetComponentInChildren<PlayerMovement>().rb.freezeRotation = false;
				GameObject.Find("Actif").GetComponent<ChronoMove>().enabled = true;
				//GameObject.Find("Actif").GetComponentInChildren<HPBar>().HP = GameObject.Find("Actif").GetComponentInChildren<HPBar>().HP - 10;
			}
		}

		if (currentTime == 0)
		{
			Destroy(gameObject);
		}

}

	void explode()
	{
		/*
		Collider2D[] objects = Physics2D.OverlapCircleAll(transform.position, fieldoImpact, LayerToHit);
		foreach (Collider2D obj in objects)
		{
			Vector2 direction = obj.transform.position - transform.position;
			obj.GetComponent<Rigidbody2D>().AddForce(direction * force);
		}

		//GameObject.Find("Rouge").GetComponent<PlayerMovement>().enabled = false;
		//GameObject.Find("Mechant").GetComponent<MechantMovement>().enabled = false;
		*/

		GameObject ExplosionEffectIns = Instantiate(ExplosionEffect, transform.position, Quaternion.identity);

		Destroy(ExplosionEffectIns, 10);
		//Destroy(gameObject);
	}

	void OnDrawGizmosSelected() // Zone d'impacte
	{
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere(transform.position, fieldoImpact);
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (!hasHit)
		{
			hasHit = true;
		}
	}
}
