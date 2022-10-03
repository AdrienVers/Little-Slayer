using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtincteurManager : MonoBehaviour
{
	// Weapon
	public int rotationSpeed = 0;

	public Transform ShootPointRight;
	public Transform ShootPointLeft;

	// Fire
	public GameObject fire;

	// Bullet
	public GameObject bullet;
	float fireRate = 0.2f;
	float lastShot = 0.0f;

	// Chrono
	public GameObject Chrono;
	public bool chrono = false;

	// Adversaire
	public bool Mechant30 = false;
	public GameObject DetectionMechant;

	private void Awake()
	{
		if (GetComponentInParent<PlayerMovement>().transform.localScale.x == -0.8f && transform.localScale.x == 1)
		{
			transform.eulerAngles = new Vector3(0, 0, 180);
			transform.localScale = new Vector3(-1, -1, 0);
		}

		if (GetComponentInParent<PlayerMovement>().transform.localScale.x == -0.8f && transform.localScale.x == -1)
		{
			transform.eulerAngles = new Vector3(0, 0, 180);
			transform.localScale = new Vector3(1, -1, 0);
		}

		if (GetComponentInParent<PlayerMovement>().transform.localScale.x == 0.8f && transform.localScale.x == 1)
		{
			transform.eulerAngles = new Vector3(0, 0, 0);
			transform.localScale = new Vector3(1, 1, 0);
		}

		if (GetComponentInParent<PlayerMovement>().transform.localScale.x == 0.8f && transform.localScale.x == -1)
		{
			transform.eulerAngles = new Vector3(0, 0, 0);
			transform.localScale = new Vector3(-1, 1, 0);
		}
	}


	void Start()
	{
		fire.SetActive(false);
		Chrono.SetActive(false);
	}

	void Update()
	{
		int distancex = Mathf.Abs(Mathf.RoundToInt(GameObject.Find("Inactif").GetComponentInChildren<PlayerMovement>().transform.position.x - transform.position.x));
		int distancey = Mathf.Abs(Mathf.RoundToInt(GameObject.Find("Inactif").GetComponentInChildren<PlayerMovement>().transform.position.y - transform.position.y));

		if (distancex <= 7 && distancex >= 0 && distancey <= 7 && distancey >= 0)
		{
			DetectionMechant.GetComponent<SpriteRenderer>().color = Color.red;
			Mechant30 = true;
		}

		else
		{
			DetectionMechant.GetComponent<SpriteRenderer>().color = Color.green;
			Mechant30 = false;
		}

		if (Input.GetKeyUp(KeyCode.Space))
		{
			fire.SetActive(true);
			Chrono.SetActive(true);
			chrono = true;
		}


		if (chrono == true)
		{
			if (GetComponentInChildren<TimerExtinceur>().currentTime != 0)
			{
				if (Time.time > fireRate + lastShot)
				{
					Shoot(bullet);

					// Rajouter endroit de detection (référence tourelle trigger)
					if (Mechant30 == true)
					{
						GameObject.Find("Inactif").GetComponentInChildren<HPBar>().HP = GameObject.Find("Inactif").GetComponentInChildren<HPBar>().HP - 1;
					}

					lastShot = Time.time;
				}
			}

			/*
			else if (GetComponentInChildren<TimerFlamme>().currentTime == 0)
			{
				fire.SetActive(false);
			}
			*/
		}

		//if (transform.eulerAngles.z <= -90) { transform.eulerAngles = new Vector3(0, 0, -90);}

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


	public void Shoot(GameObject bullet)
	{
		if (GetComponentInParent<PlayerMovement>().transform.localScale.x == 1)
		{
			GameObject newBullet1 = Instantiate(bullet, ShootPointLeft.position, transform.rotation);
		}

		if (GetComponentInParent<PlayerMovement>().transform.localScale.x == -1)
		{
			GameObject newBullet1 = Instantiate(bullet, ShootPointLeft.position, transform.rotation);
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
			float rotation = rotationSpeed;
			transform.Rotate(Vector3.forward * rotation);
		}

		else if (Input.GetKey(KeyCode.F))
		{
			float rotation = -rotationSpeed;
			transform.Rotate(Vector3.forward * rotation);
		}
	}
}