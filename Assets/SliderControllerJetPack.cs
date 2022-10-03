using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderControllerJetPack : MonoBehaviour
{
	// Player
	public GameObject activePlayer;

	void Start()
	{ }

	void LateUpdate()
	{
		if (activePlayer.transform.localScale.x == -1)
		{
			transform.localScale = new Vector3(-0.02125f, 0.02125f, 1);
		}

		if (activePlayer.transform.localScale.x == 1) // GetComponentInParent<MechantMovement>().transform.localScale.x == 1
		{
			transform.localScale = new Vector3(0.02125f, 0.02125f, 1);
		}
	}
}