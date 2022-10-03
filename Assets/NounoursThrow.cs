using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NounoursThrow : MonoBehaviour
{
	Rigidbody2D rb;
	public float fieldoImpact;
	public float force;
	//public GameObject Chrono;
	//public GameObject ExplosionEffect;
	//public LayerMask LayerToHit;

	void Start()
	{
		//if (transform.rotation.z < 180) { GetComponentInChildren<GrenadeTimer>().transform.eulerAngles = new Vector3(0, 0, 0);}
		//if (transform.rotation.z > 10 && transform.rotation.z <= 45) { GetComponentInChildren<GrenadeTimer>().transform.localPosition = new Vector3(1, 1, 0); }
		//else if (transform.rotation.z > 0 && transform.rotation.z <= 10) { GetComponentInChildren<GrenadeTimer>().transform.localPosition = new Vector3(0, 1, 0); }
	}

	void Update()
	{
	}
	/*
	void explode()
	{
		Collider2D[] objects = Physics2D.OverlapCircleAll(transform.position, fieldoImpact, LayerToHit);
		foreach (Collider2D obj in objects)
		{
			Vector2 direction = obj.transform.position - transform.position;
			obj.GetComponent<Rigidbody2D>().AddForce(direction * force);
		}

		GameObject.Find("Rouge").GetComponent<PlayerMovement>().enabled = false;
		GameObject.Find("Mechant").GetComponent<MechantMovement>().enabled = false;

		GameObject ExplosionEffectIns = Instantiate(ExplosionEffect, transform.position, Quaternion.identity);

		Destroy(ExplosionEffectIns, 10);
		Destroy(gameObject);
	}
	*/

	void OnDrawGizmosSelected() // Zone d'impacte
	{
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere(transform.position, fieldoImpact);
	}
}
