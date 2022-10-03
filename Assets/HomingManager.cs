using UnityEngine;
using System.Collections;
using System;

public class HomingManager : MonoBehaviour
{
	// Weapon
	public float rotationSpeed = 0;

	// Player
	public GameObject activePlayer;
	public Transform ShootPointRight;
	public Transform ShootPointLeft;

	public bool available = false;
	public bool veille = false;

	// Bullet
	public GameObject bullet;
	public GameObject Target;

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
		available = true;
	}

	void Update()
	{

		if (GameObject.Find("Menu") != null)
		{
			if (GameObject.Find("Menu").GetComponent<MenuCursor>().menu == true)
			{
				veille = true;
				available = false;
			}
		}

		else if (GameObject.Find("Menu") == null)
		{
			//veille = false;
			//available = true;
			if (Input.GetMouseButtonDown(0))
			{
				if (available == true)
				{
					Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
					Instantiate(Target, new Vector3(cursorPos.x, cursorPos.y, 0), Quaternion.identity);

					Shoot(bullet);

					available = false;
				}

				veille = true;
			}

		}

		if (veille == false)
		{
			if (GameObject.Find("Rouge").transform.parent == GameObject.Find("Actif").transform)
			{
				CursorController.instance.ActivateRedCursorCible();
			}

			if (GameObject.Find("Bleu").transform.parent == GameObject.Find("Actif").transform)
			{
				CursorController.instance.ActivateBlueCursorCible();
			}
		}

		if (available == false)
		{
			if (GameObject.Find("Rouge").transform.parent == GameObject.Find("Actif").transform)
			{
				CursorController.instance.ActivateRedCursor();
			}

			if (GameObject.Find("Bleu").transform.parent == GameObject.Find("Actif").transform)
			{
				CursorController.instance.ActivateBlueCursor();
			}
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
