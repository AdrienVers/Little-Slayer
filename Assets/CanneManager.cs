using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanneManager : MonoBehaviour
{
	public float rotationSpeed = 0;

	// Player
	public GameObject activePlayer;
	public Transform ShootPointRight;
	public Transform ShootPointLeft;

	private float counter;

	bool hasHit = false;
	public float Force;

	// Bullet
	public GameObject Impact;

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
	{ }

	void Update()
	{

		if (Input.GetKey(KeyCode.Space))
		{
			counter += 0.01f;

			if (counter >= 0.9f) { counter = 0.9f; }

			GetComponentInChildren<Canne>().transform.localPosition = new Vector3(-counter, 0, 0);
		}

		if (Input.GetKeyUp(KeyCode.Space))
		{
			GetComponentInChildren<Canne>().transform.localPosition = new Vector3(0.4f, 0, 0);
			Shoot(Impact);
		}

		if (Input.GetKeyDown(KeyCode.Space))
		{
			counter = 0f;
		}

		/*
		if (counter <= 0.1f) { Force = 100; }
		else if (0.1f < counter && counter <= 0.2f) { Force = 200; }
		else if (0.2f < counter && counter <= 0.3f) { Force = 300; }
		else if (0.3f < counter && counter <= 0.4f) { Force = 400; }
		else if (0.4f < counter && counter <= 0.5f) { Force = 500; }
		else if (0.5f < counter && counter <= 0.6f) { Force = 800; }
		else if (0.6f < counter && counter <= 0.7f) { Force = 900; }
		else if (0.7f < counter && counter <= 0.8f) { Force = 1200; }
		else if (0.8f < counter && counter <= 0.9f) { Force = 1500; }
		*/


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
			float rotation = rotationSpeed;
			transform.Rotate(Vector3.forward * rotation);
		}

		else if (Input.GetKey(KeyCode.F))
		{
			float rotation = -rotationSpeed;
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