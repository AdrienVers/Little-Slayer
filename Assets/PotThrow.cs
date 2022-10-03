using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotThrow : MonoBehaviour
{
	bool hasHit = false;

	void Start()
    {
        
    }

    void Update()
    {
		if (hasHit)
		{ 
			Destroy(gameObject);
		}

		if (GetComponentInChildren<PotTimer>().currentTime == 0)
		{
			Destroy(gameObject);
		}
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (!hasHit)
		{
			if (col.gameObject.tag == "Player")
			{
				hasHit = true;
			}
		}
	}
}
