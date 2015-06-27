using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    Animator animator;
    Rigidbody2D rigidbody;
    public Vector2 speed = new Vector2(50, 0);
    private Vector2 movement;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
        rigidbody = (Rigidbody2D)GetComponent<Rigidbody2D>();
	}

    void Update() {
        float inputX = Input.GetAxis("Horizontal");
        movement = new Vector2(speed.x * inputX, 0);
    }

	// Update is called once per frame
    void FixedUpdate() {
        MoveCharacter();

        rigidbody.velocity = movement;
	}

    void MoveCharacter() {
        if (Input.GetKey(KeyCode.W)) {
            animator.SetBool("jump", true);
        } else {
            animator.SetBool("jump", false);
        }

        if (Input.GetKey(KeyCode.S)) {
            animator.SetBool("slide", true);
        } else {
            animator.SetBool("slide", false);
        }
    }
}
