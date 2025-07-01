using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Untuk Menggerakan Pemain (Kanan, Kiri, Lompat)
    public float kecepatan, jumpForce;
    public bool isFacingRight;
    Rigidbody2D rb;

    // GroundCheck, untuk mendeteksi ada tidaknya ground.
    public float radius;
    public Transform groundChecker;
    public LayerMask WhatIsGround;

    // Animasi
    Animator anim;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        jump();
    }

    private void FixedUpdate()
    {
        movement();
    }

    void movement()
    {
        float move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(move * kecepatan, rb.velocity.y);

        if (move != 0)
        {
            anim.SetTrigger("run");
        }
        else
        {
            anim.SetTrigger("idle");
        }

        if (move > 0 && isFacingRight == false)
        {
            transform.eulerAngles = Vector2.zero;
            isFacingRight = true;
        }
        else if (move < 0 && isFacingRight == true)
        {
            transform.eulerAngles = Vector2.up * 180;
            isFacingRight = false;
        }
    }

    void jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }

    bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundChecker.position, radius, WhatIsGround);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(groundChecker.position, radius);
    }
}
