using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private float horizontal;
    private float speed = 5f;
    private bool isFacingRight = true;
    public float jumpForce = 8f;
    private bool isGrounded = false;

    [SerializeField] private Rigidbody2D rb;

    public GameObject _hands;

    private void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
        if(horizontal != 0)
        {
            gameObject.GetComponent<Animator>().SetBool("IsWalking", true);
            _hands.GetComponent<Animator>().SetBool("IsWalkingHand", true);
        }
        else
        {
            gameObject.GetComponent<Animator>().SetBool("IsWalking", false);
            _hands.GetComponent<Animator>().SetBool("IsWalkingHand", false);
        }
        Flip();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }


    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;

            transform.Rotate(0f, 180f, 0f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
    }
}

