using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SabreLaserManager : MonoBehaviour
{
	public float rotationSpeed = 0;

	// Player
	public GameObject activePlayer;
	public Transform ShootPointRight;
	public Transform ShootPointLeft;

	public float Force;

	// Bullet
	public bool HasHit = false;
	public bool SansTete = false;

	private void Awake()
	{
		if (GetComponentInParent<PlayerMovement>().transform.localScale.x == -1 && transform.localScale.x == 1)
		{
			transform.eulerAngles = new Vector3(0, 0, 180);
			transform.localScale = new Vector3(-1, -1, 0);
		}

		if (GetComponentInParent<PlayerMovement>().transform.localScale.x == -1 && transform.localScale.x == -1)
		{
			transform.eulerAngles = new Vector3(0, 0, 180);
			transform.localScale = new Vector3(1, -1, 0);
		}

		if (GetComponentInParent<PlayerMovement>().transform.localScale.x == 1 && transform.localScale.x == 1)
		{
			transform.eulerAngles = new Vector3(0, 0, 0);
			transform.localScale = new Vector3(1, 1, 0);
		}

		if (GetComponentInParent<PlayerMovement>().transform.localScale.x == 1 && transform.localScale.x == -1)
		{
			transform.eulerAngles = new Vector3(0, 0, 0);
			transform.localScale = new Vector3(-1, 1, 0);
		}
	}

	void Start()
	{
		//GetComponentInChildren<PolygonCollider2D>().enabled = false;
		//coup.enabled = false;
		GetComponent<Animator>().enabled = false;
	}

	void Update()
	{

		if (Input.GetKeyUp(KeyCode.Space))
		{
			GetComponent<Animator>().enabled = true;
			SansTete = true;

		}

		if (GameObject.Find("Actif").GetComponentInChildren<SabreLaserManager>().SansTete == true)
		{
			GameObject.Find("Inactif").GetComponentInChildren<HPBar>().Vivant.SetActive(false);
			GameObject.Find("Inactif").GetComponentInChildren<HPBar>().SansTete.SetActive(true);
		}



		if (GetComponentInParent<PlayerMovement>().transform.localScale.x == -1)
		{
			transform.localScale = new Vector3(-1, -1, 0);

			if (Input.GetKey(KeyCode.Q))
			{
				transform.eulerAngles = new Vector3(0, 0, 180);
			}

			if (transform.eulerAngles.z <= 89) { transform.eulerAngles = new Vector3(0, 0, 90); } // HAUT
			if (transform.eulerAngles.z >= 270 && transform.eulerAngles.z <= 360) { transform.eulerAngles = new Vector3(0, 0, -90); } // BAS

		}

		if (GetComponentInParent<PlayerMovement>().transform.localScale.x == 1)
		{
			transform.localScale = new Vector3(1, 1, 0);

			if (Input.GetKey(KeyCode.D))
			{
				transform.eulerAngles = new Vector3(0, 0, 0);
			}

			if (transform.eulerAngles.z >= 90 && transform.eulerAngles.z <= 180) { transform.eulerAngles = new Vector3(0, 0, 90); } // HAUT
			if (transform.eulerAngles.z <= 270 && transform.eulerAngles.z >= 180) { transform.eulerAngles = new Vector3(0, 0, -90); } // BAS
		}
	}

	private void FixedUpdate()
	{
		RotateWeapon();
	}

	private void RotateWeapon()
	{
		if (Input.GetKey(KeyCode.R))
		{
			float rotation = -rotationSpeed;
			transform.Rotate(Vector3.forward * rotation);
		}

		if (Input.GetKey(KeyCode.F))
		{
			float rotation = rotationSpeed;
			transform.Rotate(Vector3.forward * rotation);
		}
	}
}