using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BleuMouvement : MonoBehaviour
{
    public float speedForce; // 5 m/s
    public float jumpForce;
    public float Dir = 1;

    public bool isJumping;
    public bool isGrounded;

    public Rigidbody2D rb;
    public Transform groundCheckLeft;
    public Transform groundCheckRight;

    void Start() { }

    void FixedUpdate()
    {
        PlayerJump();
    }

    void Update()
    {
        isGrounded = Physics2D.OverlapArea(groundCheckLeft.position, groundCheckRight.position); // création d'une ligne de collision

        if (Input.GetKeyDown(KeyCode.Z) && isGrounded) // Jump = barre espace
        {
            isJumping = true;
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
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }
    }

    void PlayerJump()
    {
        if (isJumping == true)
        {
            rb.AddForce(new Vector2(0f, jumpForce));
            isJumping = false;
        }
    }

    void PlayerRight()
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

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.collider.tag == "Lost1" || coll.collider.tag == "Lost2" || coll.collider.tag == "Lost3" || coll.collider.tag == "Lost4" || coll.collider.tag == "Box")
        {
            GameObject.Find("Bleu").GetComponent<BleuMouvement>().enabled = true;
        }
    }
}

