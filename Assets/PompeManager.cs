using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PompeManager : MonoBehaviour
{
	// Weapon
	public float rotationSpeed = 0;

	// Player
	public GameObject activePlayer;
	public Transform ShootPointRight1, ShootPointRight2, ShootPointRight3, ShootPointRight4;
	public Transform ShootPointLeft1, ShootPointLeft2, ShootPointLeft3, ShootPointLeft4;

	// Bullet
	public GameObject bullet;

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
	{ }

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Shoot(bullet);
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

	public void Shoot(GameObject bullet)
	{
		if (GetComponentInParent<PlayerMovement>().transform.localScale.x == 1)
		{
			GameObject newBullet1 = Instantiate(bullet, ShootPointRight1.position, transform.rotation);
			GameObject newBullet2 = Instantiate(bullet, ShootPointRight2.position, transform.rotation);
			GameObject newBullet3 = Instantiate(bullet, ShootPointRight3.position, transform.rotation);
			GameObject newBullet4 = Instantiate(bullet, ShootPointRight4.position, transform.rotation);
		}

		if (GetComponentInParent<PlayerMovement>().transform.localScale.x == -1)
		{
			GameObject newBullet1 = Instantiate(bullet, ShootPointLeft1.position, transform.rotation);
			GameObject newBullet2 = Instantiate(bullet, ShootPointLeft2.position, transform.rotation);
			GameObject newBullet3 = Instantiate(bullet, ShootPointLeft3.position, transform.rotation);
			GameObject newBullet4 = Instantiate(bullet, ShootPointLeft4.position, transform.rotation);
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
