using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JetPackManager : MonoBehaviour
{
    private Rigidbody2D rb;

    public float Dir = 1;
    public float speedForce = 10;
    public float JetPackForce = 30;
    public bool isFlying = false;

    public Slider Barrefuel;
    public int fuel = 300;
    public Text Textfuel;

    // Smoke
    public GameObject JetPackFlammeLeft;
    public GameObject JetPackFlammeRight;

    // JetPack (outfit)
    public GameObject JetPack;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Update()
    {
        GameObject.Find("Actif").GetComponentInChildren<PlayerMovement>().enabled = false;

        isFlying = Input.GetKey(KeyCode.Z);

        Barrefuel.value = fuel;

        if (fuel > 300)
        {
            fuel = 300;
        }

        if (fuel < 0)
        {
            fuel = 0;
        }

        Textfuel.text = fuel.ToString();

        if (Input.GetKey(KeyCode.Z))
        {
            JetPackFlammeLeft.SetActive(true);
            JetPackFlammeRight.SetActive(true);
        }
        else
        {
            JetPackFlammeLeft.SetActive(false);
            JetPackFlammeRight.SetActive(false);
        }


        if (Input.GetKey(KeyCode.Q))
        {
            PlayerLeft();
        }

        else if (Input.GetKey(KeyCode.D))
        {
            PlayerRight();
        }

        else
            rb.velocity = new Vector2(0, rb.velocity.y);

        if (fuel == 0)
        {
            GameObject.Find("Actif").GetComponentInChildren<PlayerMovement>().enabled = true;
            JetPack.SetActive(false);
            GameObject.Find("Actif").GetComponentInChildren<JetPackManager>().enabled = false;
        }
    }

    void FixedUpdate()
    {
        if (isFlying)
        {
            rb.AddForce(Vector2.up * JetPackForce);
            fuel = fuel - 1;
        }
    }

    public void PlayerRight()
    {
        Dir = 1;
        rb.velocity = new Vector2(speedForce, rb.velocity.y);
        transform.localScale = new Vector3(1, 1, 1);
    }

    public void PlayerLeft()
    {
        Dir = -1;
        rb.velocity = new Vector2(-speedForce, rb.velocity.y);
        transform.localScale = new Vector3(-1, 1, 1);
    }
}