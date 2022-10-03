using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteManager : MonoBehaviour
{
	public float rotationSpeed = 0;

	// Player
	public GameObject activePlayer;
	public Transform ShootPointRight;
	public Transform ShootPointLeft;

	private float counter;
	public float Force;

	// Bullet
	public GameObject Impact;
	public bool HasHit = false;

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
		GetComponentInChildren<PolygonCollider2D>().enabled = false;
		//coup.enabled = false;
	}

	void Update()
	{

		/*
		if (Input.GetKey(KeyCode.Space))
		{
			counter += 0.01f;

			if (counter >= 0.9f) { counter = 0.9f; }

			//transform.eulerAngles = new Vector3(0, 0, -counter); // GetComponentInChildren<Batte>().
		}
		*/

		if (Input.GetKeyUp(KeyCode.Space))
		{
			
			if (GetComponentInParent<PlayerMovement>().transform.localScale.x == 1)
			{
				transform.eulerAngles = new Vector3(0, 180, 0);
			}
			

			if (GetComponentInParent<PlayerMovement>().transform.localScale.x == -1)
			{
				transform.eulerAngles = new Vector3(160, 0, 0);
			}

			GetComponentInChildren<PolygonCollider2D>().enabled = true;
			//transform.eulerAngles = new Vector3(0, 0, 0); //GetComponentInChildren<Batte>().
			//Shoot(Impact);
		}


		if (Input.GetKeyDown(KeyCode.Space))
		{
			counter = 0f;
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

	public void Shoot(GameObject bullet)
	{

		if (GetComponentInParent<PlayerMovement>().transform.localScale.x == 1)
		{
			GameObject newBullet1 = Instantiate(bullet, ShootPointRight.position, transform.rotation);
		}

		if (GetComponentInParent<PlayerMovement>().transform.localScale.x == -1)
		{
			GameObject newBullet1 = Instantiate(bullet, ShootPointLeft.position, transform.rotation);
		}
	}
}