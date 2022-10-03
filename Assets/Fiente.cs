using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fiente : MonoBehaviour
{
	bool hasHit = false;
	bool hasHitRouge = false;
	bool hasHitBleu = false;

	void Start()
	{
		GetComponent<Animator>().Play("FientePause", -1, 0f);
	}

	void Update()
	{
		if (hasHit)
		{
			if (hasHitRouge)
			{
				GameObject.Find("Rouge").GetComponent<HPBar>().HP = GameObject.Find("Rouge").GetComponent<HPBar>().HP - 5;
				hasHitRouge = false;
			}

			else if (hasHitBleu)
			{
				GameObject.Find("Bleu").GetComponent<HPBar>().HP = GameObject.Find("Bleu").GetComponent<HPBar>().HP - 5;
				hasHitBleu = false;
			}

		}
	}


	void OnCollisionEnter2D(Collision2D col)
	{
		if (!hasHit)
		{
			if (col.gameObject.tag == "Nuage" || col.gameObject.tag == "Water" || col.gameObject.tag == "Ground" || col.gameObject.tag == "Arbre" || col.gameObject.tag == "Border")
			{
				hasHit = true;
				GetComponent<Animator>().Play("FienteSplash", -1, 0f);
				Destroy(gameObject, 0.5f);
			}

			if (col.gameObject.name == "Rouge")
			{
				hasHit = true;
				hasHitRouge = true;
				GetComponent<Animator>().Play("FienteSplash", -1, 0f);
				Destroy(gameObject, 0.5f);
			}

			else if (col.gameObject.name == "Bleu")
			{
				hasHit = true;
				hasHitBleu = true;
				GetComponent<Animator>().Play("FienteSplash", -1, 0f);
				Destroy(gameObject, 0.5f);
			}

		}
	}
}
