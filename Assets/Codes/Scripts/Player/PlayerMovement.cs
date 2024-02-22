using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private float horizontal;
    private float walkSpeed = 3f;
    private bool isFacingRight = true;
    public float jumpForce = 8f;
    private bool isGrounded = false;
    public bool fox1Active = true;
    private bool doubleJump = true;
    public bool canMove = true;
    private float facingDirection = 1;

    public Rigidbody2D rb;

    public GameObject _hands;
    private Animator PlayerAnimator;
    private Animator HandAnimator;
    public GameObject _player;
    public RuntimeAnimatorController BadPlayerAnimatorController;
    public RuntimeAnimatorController PlayerAnimatorController;
    public RuntimeAnimatorController HandAnimatorController;
    public RuntimeAnimatorController BadHandAnimatorController;

    public GameObject Dust;
    private Animator DustAnimator;
    public float FacingDirection
    {
        get { return facingDirection; }
    }

    private void Start()
    {
        DustAnimator = Dust.GetComponent<Animator>();
        PlayerAnimator = gameObject.GetComponent<Animator>();
        HandAnimator = _hands.GetComponent<Animator>();
    }

    private void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        if (isGrounded && Input.GetButton("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            Animate("Jump", true);
        }
        else if (!fox1Active && doubleJump)
        {
            if (Input.GetButtonDown("Jump"))
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
                doubleJump = !doubleJump;
            }
        }
        else
        {
            Animate("Jump", false);
        }

        if (!isGrounded)
        {
            Animate("Jump", true);
        }
        else
        {
            Animate("Jump", false);
        }

        if (horizontal != 0 && isGrounded == true)
        {
            Animate("Walk", true);
        }
        else
        {
            Animate("Walk", false);
        }

        Flip();

        Swap();
    }

    private void Animate(string movementType, bool value)
    {
        PlayerAnimator.SetBool($"Is{movementType}ing", value);
        HandAnimator.SetBool($"Is{movementType}ingHand", value);
    }
    private void FixedUpdate()
    {
        if (canMove)
            rb.velocity = new Vector2(horizontal * walkSpeed, rb.velocity.y);
    }


    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            facingDirection *= -1;

            isFacingRight = !isFacingRight;

            transform.Rotate(0f, 180f, 0f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
        doubleJump = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
    }

    private void Swap()
    {
        if (Input.GetKeyDown(KeyCode.Q) && fox1Active)
        {
            walkSpeed = 4.5f;
            fox1Active = false;
            DustAnimator.SetTrigger("IsQ");
            PlayerAnimator.runtimeAnimatorController = BadPlayerAnimatorController;
            HandAnimator.runtimeAnimatorController = BadHandAnimatorController;
        }

        else if (Input.GetKeyDown(KeyCode.Q) && !fox1Active)
        {
            walkSpeed = 3f;
            fox1Active = true;
            DustAnimator.SetTrigger("IsQ");
            PlayerAnimator.runtimeAnimatorController = PlayerAnimatorController;
            HandAnimator.runtimeAnimatorController = HandAnimatorController;
        }

    }
}

