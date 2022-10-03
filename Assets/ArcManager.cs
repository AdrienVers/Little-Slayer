using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcManager : MonoBehaviour
{
	public float rotationSpeed = 0;
	public Transform ShootPointRight;
	public Transform ShootPointLeft;

	// DrawLine
	public GameObject activeDrawLine;

	// Player
	public GameObject activePlayer;

	// Bullet
	public GameObject bullet;


	void Start()
	{ }

	void LateUpdate()
	{
		if (GetComponentInChildren<DrawLine>().canShoot == true && Input.GetKeyUp(KeyCode.Space)) //  
		{
			Shoot(bullet);
		}

		if (GetComponentInParent<PlayerMovement>().transform.localScale.x == -1)
		{
			transform.localScale = new Vector3(-1, -1, 0); // Modification ici

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
			GameObject newBullet = Instantiate(bullet, ShootPointRight.position, transform.rotation);
			newBullet.GetComponent<Rigidbody2D>().AddForce(transform.right * GetComponentInChildren<DrawLine>().LaunchForce);
		}

		if (GetComponentInParent<PlayerMovement>().transform.localScale.x == -1)
		{
			GameObject newBullet = Instantiate(bullet, ShootPointLeft.position, transform.rotation);
			newBullet.GetComponent<Rigidbody2D>().AddForce(transform.right * GetComponentInChildren<DrawLine>().LaunchForce);
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