﻿using UnityEngine;
using System.Collections;

public class Thief : MonoBehaviour {

	// Use this for initialization
    public LayerMask whatIsGround;
    public Transform groundCheck;
    float groundRadius = 0.1121216f;

    public float TopMovement;
    public float Speed;
    public float Position;
    public bool Vive100On = false;

    bool IsInGround = false;
    public float JmpPwr = 1000f;

    Animator anim;
    Controllers ThiefController;
    void Awake()
    {
        anim = transform.GetComponent<Animator>();
        ThiefController = GameObject.FindGameObjectWithTag(Tags.ThiefController).GetComponent<Controllers>();
    }

	// Update is called once per frame
	void FixedUpdate()
    {
        Position = transform.position.x;
        Jump();
        CheckPowerUp();
    }

    void Jump()
    {
        //IF CHARACTER CAN JUMP DO IT

        IsInGround = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
        anim.SetFloat("Vspeed", GetComponent<Rigidbody2D>().velocity.y);
        anim.SetBool("ground", IsInGround);
        if (IsInGround && ThiefController.JumpTime)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, JmpPwr));
        }
    }

    void CheckPowerUp() {
        if (transform.position.x >= TopMovement) {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, GetComponent<Rigidbody2D>().velocity.y);
            Vive100On = false;
        }
    }

    void OnTriggerEnter2D(Collider2D col) {
        if (col.tag == Tags.Vive100) {
            GetComponent<Rigidbody2D>().velocity = new Vector2(Speed, GetComponent<Rigidbody2D>().velocity.y);
            Vive100On = true;
            Destroy(col.gameObject);
        }
    }


}
