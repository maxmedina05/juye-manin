using UnityEngine;
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
    public float JmpPwr = 200f;

    Animator anim;
    Controllers ThiefController;
    private Rigidbody2D rigidbody;
    AmetController amet;
    void Awake() {
        anim = transform.GetComponent<Animator>();
        ThiefController = GameObject.FindGameObjectWithTag(Tags.ThiefController).GetComponent<Controllers>();
        rigidbody = GetComponent<Rigidbody2D>();
        amet = GameObject.FindGameObjectWithTag(Tags.amet).GetComponent<AmetController>();
    }

    // Update is called once per frame
    void FixedUpdate() {
        Position = transform.position.x;
        Jump();
        //CheckPowerUp();
    }

    void Jump() {
        //IF CHARACTER CAN JUMP DO IT

        IsInGround = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
        anim.SetFloat("Vspeed", rigidbody.velocity.y);
        anim.SetBool("ground", IsInGround);

        if (IsInGround && ThiefController.JumpTime) {

            //Vector2 velocity = rigidbody.velocity;
            //rigidbody.velocity = new Vector2(rigidbody.velocity.x, 0);
            rigidbody.velocity = new Vector2(0, 0);
            rigidbody.AddForce(new Vector2(0, JmpPwr));
        }

    }

    void CheckPowerUp() {
        if (transform.position.x >= TopMovement) {
            rigidbody.velocity = new Vector2(0, rigidbody.velocity.y);
            Vive100On = false;
        }
    }


}
