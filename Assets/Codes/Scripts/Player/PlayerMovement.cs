using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private float horizontal;
    private float walkSpeed = 5f;
    private float runSpeed = 7f;
    private float currentSpeed;
    private bool isFacingRight = true;
    public float jumpForce = 8f;
    private bool isGrounded = false;
    public float playerStamina;
    private float staminaDrain = 2.5f;
    private float staminaRegen = 0.5f;
    private float maxStaminaFox1 = 11f;
    private float maxStaminaFox2 = 13f;
    private float maxStamina;
    private bool isSprinting = false;
    private bool fox1Active = true;

    [SerializeField] private Rigidbody2D rb;

    public GameObject _hands;

    private void Start()
    {
        playerStamina = maxStaminaFox1;
        maxStamina = maxStaminaFox1;
    }

    private void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            gameObject.GetComponent<Animator>().SetBool("IsJumping", true);
            _hands.GetComponent<Animator>().SetBool("IsJumpingHand", true);
            gameObject.GetComponent<Animator>().SetBool("IsWalking", false);
            _hands.GetComponent<Animator>().SetBool("IsWalkingHand", false);
        }
        else
        {
            gameObject.GetComponent<Animator>().SetBool("IsJumping", false);
            _hands.GetComponent<Animator>().SetBool("IsJumpingHand", false);
        }

        if (horizontal != 0 && isGrounded == true)
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

        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (playerStamina > 0f)
            {
                currentSpeed = runSpeed; isSprinting = true;
                playerStamina -= staminaDrain * Time.deltaTime;
            }
        }
        else
        {
            currentSpeed = walkSpeed; isSprinting = false;
        }
        if (!isSprinting)
        {
            if (playerStamina < maxStamina)
            {
                playerStamina += staminaRegen * Time.deltaTime;
            }
        }

        Swap();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * currentSpeed, rb.velocity.y);
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

    private void Swap()
    {
        if (Input.GetKeyDown(KeyCode.Q) && fox1Active)
        {
            runSpeed = 10f;
            walkSpeed = 3.5f;
            staminaDrain = 1.5f;
            staminaRegen = 0.8f;
            maxStamina = maxStaminaFox2;
            fox1Active = false;
        }
        
        else if (Input.GetKeyDown(KeyCode.Q) && !fox1Active)
        {
                runSpeed = 7f;
                walkSpeed = 5f;
                staminaDrain = 2.5f;
                staminaRegen = 0.5f;
                maxStamina = maxStaminaFox1;
                fox1Active = true;
        }
    }
}

